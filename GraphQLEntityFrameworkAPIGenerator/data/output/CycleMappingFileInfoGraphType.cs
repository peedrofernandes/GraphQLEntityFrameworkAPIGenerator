
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WP.Cooking.GESE.WebAPI.Models;
using GraphQL.DataLoader;
using WP.Cooking.GESE.WebAPI.Repositories; 


namespace WP.Cooking.GESE.WebAPI.GraphQL.Types
{
    public partial class CycleMappingFileInfoGraphType : ObjectGraphType<CycleMappingFileInfo>
    {
        public CycleMappingFileInfoGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleMappingFileInfoId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.FileId, type: typeof(StringGraphType), nullable: False);
			Field(t => t.HexEncoding, type: typeof(ByteGraphType), nullable: False);
            
            Field<CycleMappingModelNumberGraphType, CycleMappingModelNumber>("CycleMappingModelNumbers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingModelNumberGraphType>>(
                        "CycleMappingFileInfo-CycleMappingModelNumber-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingFileInfoCycleMappingModelNumber
                                .Where(x => x.CycleMappingFileInfoId != null && ids.Contains((Guid)x.CycleMappingFileInfoId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMappingFileInfoId!,
                                    Value = x.CycleMappingModelNumber,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleMappingModelNumbers);
                });
            
			
            Field<CycleMappingGraphType, CycleMapping>("CycleMappings")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingGraphType>>(
                        "CycleMappingFileInfo-CycleMapping-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappings
                                .Where(x => x.CycleMapping != null && ids.Contains((Guid)x.CycleMapping))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleMapping!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.CycleMappings);
                });
            
			
            Field<CycleMappingProductVariantGraphType, CycleMappingProductVariant>("CycleMappingProductVariants")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleMappingProductVariantGraphType>(
                        "CycleMappingFileInfo-CycleMappingProductVariant-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleMappingProductVariants
                                .Where(x => x.CycleMappingProductVariant != null && ids.Contains((byte)x.CycleMappingProductVariant))
                                .Select(x => new
                                {
                                    Key = (byte)x.CycleMappingProductVariant!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleMappingProductVariant);
                });
            
        }
    }
}
            
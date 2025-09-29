
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
    public partial class UiledDriverParameterGraphType : ObjectGraphType<UiledDriverParameter>
    {
        public UiledDriverParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiledDriverParametersId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.LedName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Parameter1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Parameter2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Parameter3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<UiledDriverTypeGraphType, UiledDriverType>("UiledDriverTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, UiledDriverTypeGraphType>(
                        "UiledDriverParameter-UiledDriverType-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledDriverTypes
                                .Where(x => x.UiledDriverType != null && ids.Contains((byte)x.UiledDriverType))
                                .Select(x => new
                                {
                                    Key = (byte)x.UiledDriverType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiledDriverType);
                });
            
			
            Field<UiledConfigurationGraphType, UiledConfiguration>("UiledConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiledConfigurationGraphType>>(
                        "UiledDriverParameter-UiledConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiledConfigurationsUiledDriverParameter
                                .Where(x => x.UiledConfigurationsId != null && ids.Contains((Guid)x.UiledConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiledConfigurationsId!,
                                    Value = x.UiledConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiledConfigurations);
                });
            
        }
    }
}
            
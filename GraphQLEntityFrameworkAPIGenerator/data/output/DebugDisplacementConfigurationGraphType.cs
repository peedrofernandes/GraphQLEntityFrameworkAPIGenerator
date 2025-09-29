
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
    public partial class DebugDisplacementConfigurationGraphType : ObjectGraphType<DebugDisplacementConfiguration>
    {
        public DebugDisplacementConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DebugDisplacementConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FlagOneDataType, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DataType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<DebugDataDetailGraphType, DebugDataDetail>("DebugDataDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DebugDataDetailGraphType>>(
                        "DebugDisplacementConfiguration-DebugDataDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.DebugDisplacementConfigurationsDebugDataDetail
                                .Where(x => x.DebugDisplacementConfigurationsId != null && ids.Contains((Guid)x.DebugDisplacementConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DebugDisplacementConfigurationsId!,
                                    Value = x.DebugDataDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.DebugDataDetails);
                });
            
			
            Field<DebugPointerConfigurationGraphType, DebugPointerConfiguration>("DebugPointerConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DebugPointerConfigurationGraphType>>(
                        "DebugDisplacementConfiguration-DebugPointerConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.DebugPointerConfigurationsDebugDisplacementConfiguration
                                .Where(x => x.DebugPointerConfigurationsId != null && ids.Contains((Guid)x.DebugPointerConfigurationsId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.DebugPointerConfigurationsId!,
                                    Value = x.DebugPointerConfigurations,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.DebugPointerConfigurations);
                });
            
        }
    }
}
            
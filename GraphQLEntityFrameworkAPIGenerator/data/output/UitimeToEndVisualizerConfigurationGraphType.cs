
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
    public partial class UitimeToEndVisualizerConfigurationGraphType : ObjectGraphType<UitimeToEndVisualizerConfiguration>
    {
        public UitimeToEndVisualizerConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UitimeToEndVisualizerId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<UitimeToEndVisualizerDetailGraphType, UitimeToEndVisualizerDetail>("UitimeToEndVisualizerDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UitimeToEndVisualizerDetailGraphType>>(
                        "UitimeToEndVisualizerConfiguration-UitimeToEndVisualizerDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.UitimeToEndVisualizerConfigurationsUitimeToEndVisualizerDetail
                                .Where(x => x.UitimeToEndVisualizerId != null && ids.Contains((Guid)x.UitimeToEndVisualizerId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UitimeToEndVisualizerId!,
                                    Value = x.UitimeToEndVisualizerDetail,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UitimeToEndVisualizerDetails);
                });
            
        }
    }
}
            
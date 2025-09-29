
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
    public partial class PrmLoadFanConfigurationGraphType : ObjectGraphType<PrmLoadFanConfiguration>
    {
        public PrmLoadFanConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.FanType, type: typeof(ByteGraphType), nullable: False);
            
            Field<PrmLoadFanDetailGraphType, PrmLoadFanDetail>("PrmLoadFanDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmLoadFanDetailGraphType>>(
                        "PrmLoadFanConfiguration-PrmLoadFanDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrmLoadFanConfigurationPrmLoadFanDetail
                                .Where(x => x.Id != null && ids.Contains((Guid)x.Id))
                                .Select(x => new
                                {
                                    Key = (Guid)x.Id!,
                                    Value = x.PrmLoadFanDetails,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.PrmLoadFanDetails);
                });
            
        }
    }
}
            
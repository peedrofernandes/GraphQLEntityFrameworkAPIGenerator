
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
    public partial class SrhmieventCheckParameterGraphType : ObjectGraphType<SrhmieventCheckParameter>
    {
        public SrhmieventCheckParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SrhmieventCheckParametersId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CheckEvents, type: typeof(ByteGraphType), nullable: False);
            
            Field<SrsafetyRelevantParameterGraphType, SrsafetyRelevantParameter>("SrsafetyRelevantParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SrsafetyRelevantParameterGraphType>>(
                        "SrhmieventCheckParameter-SrsafetyRelevantParameter-loader",
                        async ids => 
                        {
                            var data = await dbContext.SrsafetyRelevantParameters
                                .Where(x => x.SrsafetyRelevantParameter != null && ids.Contains((Guid)x.SrsafetyRelevantParameter))
                                .Select(x => new
                                {
                                    Key = (Guid)x.SrsafetyRelevantParameter!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.SrsafetyRelevantParameters);
                });
            
        }
    }
}
            
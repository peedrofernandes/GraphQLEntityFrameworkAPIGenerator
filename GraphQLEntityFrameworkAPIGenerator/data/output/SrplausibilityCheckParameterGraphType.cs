
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
    public partial class SrplausibilityCheckParameterGraphType : ObjectGraphType<SrplausibilityCheckParameter>
    {
        public SrplausibilityCheckParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SrPlausibilityCheckParamsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfPlausibilityChecks, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AdcminThresholdForPlausibilityCheck1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.AdcmaxThresholdForPlausibilityCheck1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PlausibilityCheckGiindex1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PlausibilityCheckTemperatureGiindex1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AdcminThresholdForPlausibilityCheck2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.AdcmaxThresholdForPlausibilityCheck2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.PlausibilityCheckGiindex2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PlausibilityCheckTemperatureGiindex2, type: typeof(ByteGraphType), nullable: False);
            
            Field<SrsafetyRelevantParameterGraphType, SrsafetyRelevantParameter>("SrsafetyRelevantParameters")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<SrsafetyRelevantParameterGraphType>>(
                        "SrplausibilityCheckParameter-SrsafetyRelevantParameter-loader",
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
            
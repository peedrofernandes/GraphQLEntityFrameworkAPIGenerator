
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
    public partial class CycleOptionsStepDetailGraphType : ObjectGraphType<CycleOptionsStepDetail>
    {
        public CycleOptionsStepDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleOptionsStepDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.UserPhaseNameId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.InstructionId, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TableTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfLevels, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Time1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Coefficient5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time6, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time7, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId7, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Time8, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.PowerLevelId8, type: typeof(ByteGraphType), nullable: False);
            
            Field<CycleOptionsPrmStepsConfigurationGraphType, CycleOptionsPrmStepsConfiguration>("CycleOptionsPrmStepsConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsPrmStepsConfigurationGraphType>>(
                        "CycleOptionsStepDetail-CycleOptionsPrmStepsConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail
                                .Where(x => x.CycleOptionsPrmStepsConfigId != null && ids.Contains((Guid)x.CycleOptionsPrmStepsConfigId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.CycleOptionsPrmStepsConfigId!,
                                    Value = x.CycleOptionsPrmStepsConfig,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleOptionsPrmStepsConfigurations);
                });
            
        }
    }
}
            
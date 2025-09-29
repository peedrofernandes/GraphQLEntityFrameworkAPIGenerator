
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
    public partial class CycleOptionsPrmTemperatureGraphType : ObjectGraphType<CycleOptionsPrmTemperature>
    {
        public CycleOptionsPrmTemperatureGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.TemperatureOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Upo, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.TemperatureSelectionCelsiusMinimum, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureSelectionCelsiusDefault, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureSelectionCelsiusMaximum, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.MaximumStartTemperature, type: typeof(DoubleGraphType), nullable: False);
			Field(t => t.StepCelsius, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StepFahrenheit, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfSelections, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureSelection4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureSelection5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureSelection6, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Units, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureSelectionName1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureSelectionName2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureSelectionName3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureSelectionName4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureSelectionName5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TemperatureSelectionName6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConfigureMaxTemp, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.TemperatureSelectionDefaultName, type: typeof(ByteGraphType), nullable: False);
            
            Field<CycleTemperatureOptionsBehaviorLabelGraphType, CycleTemperatureOptionsBehaviorLabel>("CycleTemperatureOptionsBehaviorLabels")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleTemperatureOptionsBehaviorLabelGraphType>(
                        "CycleOptionsPrmTemperature-CycleTemperatureOptionsBehaviorLabel-loader",
                        async ids => 
                        {
                            var data = await dbContext.CycleTemperatureOptionsBehaviorLabels
                                .Where(x => x.CycleTemperatureOptionsBehaviorLabel != null && ids.Contains((byte)x.CycleTemperatureOptionsBehaviorLabel))
                                .Select(x => new
                                {
                                    Key = (byte)x.CycleTemperatureOptionsBehaviorLabel!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.CycleTemperatureOptionsBehaviorLabel);
                });
            
        }
    }
}
            
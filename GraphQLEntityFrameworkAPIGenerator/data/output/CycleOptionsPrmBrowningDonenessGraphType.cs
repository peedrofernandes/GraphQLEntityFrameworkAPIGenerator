
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
    public partial class CycleOptionsPrmBrowningDonenessGraphType : ObjectGraphType<CycleOptionsPrmBrowningDoneness>
    {
        public CycleOptionsPrmBrowningDonenessGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.BrowningDonenessOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DefaultSelection, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.GroupingDesignation, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConfigureTime, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ConfigureTemp, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Option1, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Time1, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Temp1, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Option2, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Time2, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Temp2, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Option3, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Time3, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Temp3, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Option4, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Time4, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Temp4, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.Option5, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Time5, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Temp5, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TemperatureType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TimeType, type: typeof(ByteGraphType), nullable: False);
            
        }
    }
}
            
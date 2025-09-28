
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
    public partial class VariableBaseTrackGraphType : ObjectGraphType<VariableBaseTrack>
    {
        public VariableBaseTrackGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProductTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableOffset, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.VariableType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TrackName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.TrackId, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TrackType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TrackHelpLabel, type: typeof(StringGraphType), nullable: True);
			Field(t => t.IsWritable, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.TrackMeasUnit, type: typeof(StringGraphType), nullable: True);
			Field(t => t.TrackColor, type: typeof(LongGraphType), nullable: False);
			Field(t => t.TrackWidth, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TrackStyle, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TrackAutoscale, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.TrackEnabled, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.TrackDecs, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TrackMeanDecs, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TrackDevDecs, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TrackMultMetSciNotation, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.TrackSaveDecs, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TrackAcqFileSciNotation, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.TrackVmin, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TrackVmax, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.TrackTime, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TrackDependances, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DisplayName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Tag, type: typeof(StringGraphType), nullable: False);
			Field(t => t.TrackMultiplier, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TrackFormula, type: typeof(StringGraphType), nullable: False);
            
        }
    }
}
            
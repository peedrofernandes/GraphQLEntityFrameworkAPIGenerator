
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
    public partial class StmHeatRunViewGraphType : ObjectGraphType<StmHeatRunView>
    {
        public StmHeatRunViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.OpenLoopNumberOfLoads, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ClosedLoopNumberOfLoads, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OpenLoopDutyPeriod, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.ClosedLoopDutyPeriod, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.OpenLoopStartTimeLoad1, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.OpenLoopStopTimeLoad1, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.OpenLoopMagnetronTargetLoad1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OpenLoopBroilUserControl1, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.OpenLoopLoadId1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OpenLoopStartTimeLoad2, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.OpenLoopStopTimeLoad2, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.OpenLoopMagnetronTargetLoad2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OpenLoopBroilUserControl2, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.OpenLoopLoadId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OpenLoopStartTimeLoad3, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.OpenLoopStopTimeLoad3, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.OpenLoopMagnetronTargetLoad3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OpenLoopBroilUserControl3, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.OpenLoopLoadId3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OpenLoopStartTimeLoad4, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.OpenLoopStopTimeLoad4, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.OpenLoopMagnetronTargetLoad4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OpenLoopBroilUserControl4, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.OpenLoopLoadId4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OpenLoopStartTimeLoad5, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.OpenLoopStopTimeLoad5, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.OpenLoopMagnetronTargetLoad5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OpenLoopBroilUserControl5, type: typeof(BoolGraphType), nullable: True);
			Field(t => t.OpenLoopLoadId5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ClosedLoopStartTimeLoad1, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.ClosedLoopStopTimeLoad1, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.ClosedLoopLoadId1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ClosedLoopStartTimeLoad2, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.ClosedLoopStopTimeLoad2, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.ClosedLoopLoadId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ClosedLoopStartTimeLoad3, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.ClosedLoopStopTimeLoad3, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.ClosedLoopLoadId3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ClosedLoopStartTimeLoad4, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.ClosedLoopStopTimeLoad4, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.ClosedLoopLoadId4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ClosedLoopStartTimeLoad5, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.ClosedLoopStopTimeLoad5, type: typeof(FloatGraphType), nullable: True);
			Field(t => t.ClosedLoopLoadId5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ConvectionFanId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ConvectionStartTime, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ConvectionStopTime, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PidConfigurationId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LbopenLoopId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ConvectionFan1Id, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ConvectionFan2Id, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LbclosedLoopId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.NumberOfLinkedRings, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ConvectionRingLoad1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ConvectionRingLoad2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.UseOpenLoopPeriod, type: typeof(BoolGraphType), nullable: True);
            
        }
    }
}
            

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
    public partial class CompartmentNamesAndLoadsViewGraphType : ObjectGraphType<CompartmentNamesAndLoadsView>
    {
        public CompartmentNamesAndLoadsViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Name, type: typeof(StringGraphType), nullable: False);
			Field(t => t.CompartmentType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RelayEnable, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Dlb, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Bake, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Broil1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Broil2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ConvElement1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ConvElement2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ConvFan1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ConvFan2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.LatchMotor, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Light, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ForcedConvValve, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Magnetron, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TurnTable, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MinimumOnTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MinimumOffTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Temperature1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Temperature2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.MeatProbe, type: typeof(IdGraphType), nullable: False);
			Field(t => t.DoorSwitch, type: typeof(IdGraphType), nullable: False);
			Field(t => t.LatchSwitch, type: typeof(IdGraphType), nullable: False);
			Field(t => t.DlbfeedbackIndex, type: typeof(IdGraphType), nullable: False);
			Field(t => t.HumiditySensor, type: typeof(IdGraphType), nullable: False);
			Field(t => t.LoadsFeedbackIndex, type: typeof(IdGraphType), nullable: False);
			Field(t => t.HallEffectSensorPresent, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.NumberOfCoolingFans, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Fan1SpeedGi, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Fan2SpeedGi, type: typeof(IdGraphType), nullable: False);
			Field(t => t.BackupRestore, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Light2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.SecondaryDoorSwitch, type: typeof(IdGraphType), nullable: False);
			Field(t => t.ToastSensor, type: typeof(IdGraphType), nullable: False);
			Field(t => t.SecondaryDlb, type: typeof(IdGraphType), nullable: False);
			Field(t => t.SecondaryDlbFeedbackIndex, type: typeof(IdGraphType), nullable: False);
			Field(t => t.SecondaryRelayEnable, type: typeof(IdGraphType), nullable: False);
            
        }
    }
}
            
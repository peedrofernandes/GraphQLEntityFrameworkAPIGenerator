
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
    public partial class AppConfigOvenMwcompartmentGraphType : ObjectGraphType<AppConfigOvenMwcompartment>
    {
        public AppConfigOvenMwcompartmentGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.RelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Dlb, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Bake, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Broil1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Broil2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvElement1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvElement2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvFan1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvFan2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LatchMotor, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Temperature1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Temperature2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MeatProbe, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DoorSwitch, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LatchSwitch, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Light, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Magnetron, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ForcedConvValve, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TurnTable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.HumiditySensor, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DlbfeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.BackupRestore, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadsFeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.BakeFeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.BakeRelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Broil1FeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Broil1RelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Broil2FeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Broil2RelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvElement1FeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvElement1RelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvElement2FeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConvElement2RelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LatchFeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LatchRelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MagnetronFeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.MagnetronRelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TurnTableFeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TurnTableRelayEnable, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Light2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SecondaryDoorSwitch, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ToastSensor, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SecondaryDlb, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SecondaryDlbFeedbackIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SecondaryRelayEnable, type: typeof(ByteGraphType), nullable: False);
            
            Field<AppConfigCompartmentDetailGraphType, AppConfigCompartmentDetail>("AppConfigCompartmentDetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<AppConfigCompartmentDetailGraphType>>(
                        "AppConfigOvenMwcompartment-AppConfigCompartmentDetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.AppConfigCompartmentDetails
                                .Where(x => x.AppConfigCompartmentDetail != null && ids.Contains((Guid)x.AppConfigCompartmentDetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.AppConfigCompartmentDetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.AppConfigCompartmentDetails);
                });
            
        }
    }
}
            
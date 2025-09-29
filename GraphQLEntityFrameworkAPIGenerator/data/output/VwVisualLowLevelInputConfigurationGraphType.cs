
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
    public partial class VwVisualLowLevelInputConfigurationGraphType : ObjectGraphType<VwVisualLowLevelInputConfiguration>
    {
        public VwVisualLowLevelInputConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LowLevelInputConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Board, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LowLevelInputDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ReadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypePos, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsMultiplexed, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ChipSelect, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsAutomatic, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.NumReadings, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsAcline, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsVreference, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsCompensated, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsInverted, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsPartialized, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Pin1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Delta, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Rotation, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PullUp, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ChannelDischarge, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ReadParametersId, type: typeof(GuidGraphType), nullable: True);
            
        }
    }
}
            
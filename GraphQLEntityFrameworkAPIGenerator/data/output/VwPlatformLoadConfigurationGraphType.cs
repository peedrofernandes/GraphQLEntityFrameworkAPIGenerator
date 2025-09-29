
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
    public partial class VwPlatformLoadConfigurationGraphType : ObjectGraphType<VwPlatformLoadConfiguration>
    {
        public VwPlatformLoadConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LoadConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.LoadId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PilotTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Pin1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OnLevel1, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OnLevel2, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OnLevel3, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.OnLevel4, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PilotParametersId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.FeedbackParametersId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.LoadParametersId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.Uidriven, type: typeof(BoolGraphType), nullable: False);
            
        }
    }
}
            
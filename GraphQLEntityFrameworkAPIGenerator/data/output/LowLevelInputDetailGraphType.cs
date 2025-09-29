
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
    public partial class LowLevelInputDetailGraphType : ObjectGraphType<LowLevelInputDetail>
    {
        public LowLevelInputDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LowLevelInputDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ReadTypePos, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Delta, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ChipSelect, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumReadings, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsAutomatic, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsMultiplexed, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsAcline, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsVreference, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsCompensated, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsInverted, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsPartialized, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Rotation, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PullUp, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ChannelDischarge, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Pin1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ReadParametersId, type: typeof(GuidGraphType), nullable: True);
            
            Field<LowLevelInputConfigurationGraphType, LowLevelInputConfiguration>("LowLevelInputConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LowLevelInputConfigurationGraphType>>(
                        "LowLevelInputDetail-LowLevelInputConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.LowLevelInputConfigurationsLowLevelInputDetail
                                .Where(x => x.LowLevelInputConfigurationId != null && ids.Contains((Guid)x.LowLevelInputConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.LowLevelInputConfigurationId!,
                                    Value = x.LowLevelInputConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.LowLevelInputConfigurations);
                });
            
			
            Field<ReadTypeGraphType, ReadType>("ReadTypes")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ReadTypeGraphType>(
                        "LowLevelInputDetail-ReadType-loader",
                        async ids => 
                        {
                            var data = await dbContext.ReadTypes
                                .Where(x => x.ReadType != null && ids.Contains((byte)x.ReadType))
                                .Select(x => new
                                {
                                    Key = (byte)x.ReadType!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.ReadType);
                });
            
        }
    }
}
            
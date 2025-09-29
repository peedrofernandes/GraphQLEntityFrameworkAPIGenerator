
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
    public partial class UiinputEventMappingDetailGraphType : ObjectGraphType<UiinputEventMappingDetail>
    {
        public UiinputEventMappingDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiinputEventMappingDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.LlireadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LlireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumberOfInputEvents, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Value1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent4, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent5, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent6, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value7, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent7, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value8, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent8, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value9, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent9, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value10, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent10, type: typeof(IdGraphType), nullable: False);
			Field(t => t.UigireadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UigireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Value11, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent11, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value12, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent12, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value13, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent13, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value14, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent14, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value15, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent15, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value16, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent16, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value17, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent17, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value18, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent18, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value19, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent19, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value20, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent20, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value21, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent21, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value22, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent22, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value23, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent23, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value24, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent24, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value25, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent25, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value26, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent26, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value27, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent27, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value28, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent28, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value29, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent29, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value30, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent30, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value31, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent31, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Value32, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.InputEvent32, type: typeof(IdGraphType), nullable: False);
            
            Field<UiinputEventMappingConfigurationGraphType, UiinputEventMappingConfiguration>("UiinputEventMappingConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiinputEventMappingConfigurationGraphType>>(
                        "UiinputEventMappingDetail-UiinputEventMappingConfiguration-loader",
                        async ids => 
                        {
                            var data = await dbContext.UiinputEventMappingConfigurationsUiinputEventMappingDetail
                                .Where(x => x.UiinputEventMappingConfigurationId != null && ids.Contains((Guid)x.UiinputEventMappingConfigurationId))
                                .Select(x => new
                                {
                                    Key = (Guid)x.UiinputEventMappingConfigurationId!,
                                    Value = x.UiinputEventMappingConfiguration,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.UiinputEventMappingConfigurations);
                });
            
        }
    }
}
            
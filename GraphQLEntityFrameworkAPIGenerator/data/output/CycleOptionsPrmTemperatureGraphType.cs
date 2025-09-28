
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
			Field(t => t.TemperatureSelectionBehavior, type: typeof(ByteGraphType), nullable: False);
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
                            "{ Name = EntityName "CycleOptionsPrmTemperature"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleOptionsPrmTemperature"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "TemperatureOptionsId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "Status"
                     IsNullable = false }; Primitive { Type = String
                                                       Name = "Owner"
                                                       IsNullable = false };
         Primitive { Type = DateTime
                     Name = "Timestamp"
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "TemperatureSelectionBehavior"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Upo"
                                                       IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureSelectionCelsiusMinimum"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureSelectionCelsiusDefault"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureSelectionCelsiusMaximum"
                     IsNullable = false };
         Primitive { Type = Double
                     Name = "MaximumStartTemperature"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "StepCelsius"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "StepFahrenheit"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "NumberOfSelections"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureSelection4"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureSelection5"
                     IsNullable = false };
         Primitive { Type = Float
                     Name = "TemperatureSelection6"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Units"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "TemperatureSelectionName1"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "TemperatureSelectionName2"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "TemperatureSelectionName3"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "TemperatureSelectionName4"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "TemperatureSelectionName5"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "TemperatureSelectionName6"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "ConfigureMaxTemp"
                                                       IsNullable = true };
         Primitive { Type = Byte
                     Name = "TemperatureSelectionDefaultName"
                     IsNullable = false };
         Navigation { Type = TableName "CycleTemperatureOptionsBehaviorLabel"
                      Name = "TemperatureSelectionBehaviorNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "TemperatureOptionsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true };
    { Name = "TemperatureSelectionBehavior"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Upo"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "TemperatureSelectionCelsiusMinimum"
      Type = Primitive Float
      IsNullable = false }; { Name = "TemperatureSelectionCelsiusDefault"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "TemperatureSelectionCelsiusMaximum"
      Type = Primitive Float
      IsNullable = false }; { Name = "MaximumStartTemperature"
                              Type = Primitive Double
                              IsNullable = false }; { Name = "StepCelsius"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "StepFahrenheit"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NumberOfSelections"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "TemperatureSelection4"
      Type = Primitive Float
      IsNullable = false }; { Name = "TemperatureSelection5"
                              Type = Primitive Float
                              IsNullable = false };
    { Name = "TemperatureSelection6"
      Type = Primitive Float
      IsNullable = false }; { Name = "Units"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "TemperatureSelectionName1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TemperatureSelectionName2"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "TemperatureSelectionName3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TemperatureSelectionName4"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "TemperatureSelectionName5"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TemperatureSelectionName6"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ConfigureMaxTemp"
                                                      Type = Primitive Bool
                                                      IsNullable = true };
    { Name = "TemperatureSelectionDefaultName"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleTemperatureOptionsBehaviorLabel"
        TargetTable =
         { Name = TableName "CycleTemperatureOptionsBehaviorLabel"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Behavior"
                                                            IsNullable = false };
             Navigation { Type = TableName "CycleOptionsPrmTemperature"
                          Name = "CycleOptionsPrmTemperatures"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleTemperatureOptionsBehaviorLabel"
        IsNullable = false
        KeyType = Byte }] }-CycleTemperatureOptionsBehaviorLabel-loader",
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
            
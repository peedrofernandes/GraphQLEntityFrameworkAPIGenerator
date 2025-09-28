
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
    public partial class CycleTemperatureOptionsBehaviorLabelGraphType : ObjectGraphType<CycleTemperatureOptionsBehaviorLabel>
    {
        public CycleTemperatureOptionsBehaviorLabelGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Behavior, type: typeof(StringGraphType), nullable: False);
            
                Field<CycleOptionsPrmTemperatureGraphType, CycleOptionsPrmTemperature>("CycleOptionsPrmTemperatures")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleOptionsPrmTemperatureGraphType>>(
                            "{ Name = EntityName "CycleTemperatureOptionsBehaviorLabel"
  CorrespondingTable =
   Regular
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
  Fields = [{ Name = "Id"
              Type = Id Byte
              IsNullable = false }; { Name = "Behavior"
                                      Type = Primitive String
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CycleOptionsPrmTemperature"
        TargetTable =
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
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
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
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ConfigureMaxTemp"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "TemperatureSelectionDefaultName"
                         IsNullable = false };
             Navigation
               { Type = TableName "CycleTemperatureOptionsBehaviorLabel"
                 Name = "TemperatureSelectionBehaviorNavigation"
                 IsNullable = false
                 IsCollection = false }] }
        Destination = EntityName "CycleOptionsPrmTemperature"
        KeyType = Guid }] }-CycleOptionsPrmTemperature-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleOptionsPrmTemperatures
                                    .Where(x => x.CycleOptionsPrmTemperature != null && ids.Contains((Guid)x.CycleOptionsPrmTemperature))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleOptionsPrmTemperature!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleOptionsPrmTemperatures);
                    });
            
        }
    }
}
            
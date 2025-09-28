
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
    public partial class UiprmGianalogPotentiometerGraphType : ObjectGraphType<UiprmGianalogPotentiometer>
    {
        public UiprmGianalogPotentiometerGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Min, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Max, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ValMin, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ValMax, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SatMin, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SatMax, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RangeMin, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RangeMax, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.EnableRangeDetection, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.A, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.B, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.C, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TimeStamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<TableTargetGraphType, TableTarget>("TableTargets")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                            "{ Name = EntityName "UiprmGianalogPotentiometer"
  CorrespondingTable =
   Regular
     { Name = TableName "UiprmGianalogPotentiometer"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "Min"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Max"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ValMin"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ValMax"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "SatMin"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "SatMax"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "RangeMin"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "RangeMax"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "EnableRangeDetection"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "A"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "B"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "C"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Owner"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Status"
                                                       IsNullable = false };
         Primitive { Type = DateTime
                     Name = "TimeStamp"
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
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Min"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Max"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ValMin"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ValMax"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "SatMin"
      Type = Primitive Byte
      IsNullable = false }; { Name = "SatMax"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "RangeMin"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "RangeMax"
      Type = Primitive Byte
      IsNullable = false }; { Name = "EnableRangeDetection"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "A"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "B"
      Type = Primitive Byte
      IsNullable = false }; { Name = "C"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Owner"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "TimeStamp"
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
                                                      IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "TableTarget"
        TargetTable =
         { Name = TableName "TableTarget"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCodeMandatory"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsTargetReleasable"
                         IsNullable = false };
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "Cycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Macro"
                          Name = "Macros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotGeneralizedProfile"
                          Name = "PilotGeneralizedProfiles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmGianalogToTemperature"
                          Name = "PrmGianalogToTemperatures"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiclassBeventConfiguration"
                          Name = "UiclassBeventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UifunctionConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionDetail"
                          Name = "UifunctionDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "Uimacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogEncoder"
                          Name = "UiprmGianalogEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGianalogPotentiometer"
                          Name = "UiprmGianalogPotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGidiscretePotentiometer"
                          Name = "UiprmGidiscretePotentiometers"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGiincrementalEncoder"
                          Name = "UiprmGiincrementalEncoders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiprmGitouchSlider"
                          Name = "UiprmGitouchSliders"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiregulationTable"
                          Name = "UiregulationTables"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "UisequenceConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uisequence"
                          Name = "Uisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uistep"
                          Name = "Uisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "TableTarget"
        IsNullable = false
        KeyType = Byte }] }-TableTarget-loader",
                            async ids => 
                            {
                                var data = await dbContext.TableTargets
                                    .Where(x => x.TableTarget != null && ids.Contains((byte)x.TableTarget))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.TableTarget!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.TableTarget);
                });
            
        }
    }
}
            
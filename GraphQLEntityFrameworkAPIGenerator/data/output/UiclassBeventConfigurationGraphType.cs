
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
    public partial class UiclassBeventConfigurationGraphType : ObjectGraphType<UiclassBeventConfiguration>
    {
        public UiclassBeventConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiclassBeventConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<TableTargetGraphType, TableTarget>("TableTargets")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                            "{ Name = EntityName "UiclassBeventConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "UiclassBeventConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiclassBeventConfigurationId"
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
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation
           { Type = TableName "UiclassBeventConfigurationsUiclassBeventDetail"
             Name = "UiclassBeventConfigurationsUiclassBeventDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UiclassBeventConfigurationId"
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
        KeyType = Byte };
    OneToMany
      { Name = RelationName "UiclassBeventConfigurationsUiclassBeventDetail"
        TargetTable =
         { Name = TableName "UiclassBeventConfigurationsUiclassBeventDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiclassBeventConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiclassBeventDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiclassBeventConfiguration"
                          Name = "UiclassBeventConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiclassBeventDetail"
                          Name = "UiclassBeventDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "UiclassBeventConfigurationsUiclassBeventDetail"
        KeyType = Guid }] }-TableTarget-loader",
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
            
			
                Field<UiclassBeventConfigurationsUiclassBeventDetailGraphType, UiclassBeventConfigurationsUiclassBeventDetail>("UiclassBeventConfigurationsUiclassBeventDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiclassBeventConfigurationsUiclassBeventDetailGraphType>>(
                            "{ Name = EntityName "UiclassBeventConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "UiclassBeventConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiclassBeventConfigurationId"
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
         Navigation { Type = TableName "TableTarget"
                      Name = "TableTargetNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation
           { Type = TableName "UiclassBeventConfigurationsUiclassBeventDetail"
             Name = "UiclassBeventConfigurationsUiclassBeventDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UiclassBeventConfigurationId"
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
        KeyType = Byte };
    OneToMany
      { Name = RelationName "UiclassBeventConfigurationsUiclassBeventDetail"
        TargetTable =
         { Name = TableName "UiclassBeventConfigurationsUiclassBeventDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiclassBeventConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiclassBeventDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiclassBeventConfiguration"
                          Name = "UiclassBeventConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiclassBeventDetail"
                          Name = "UiclassBeventDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "UiclassBeventConfigurationsUiclassBeventDetail"
        KeyType = Guid }] }-UiclassBeventConfigurationsUiclassBeventDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiclassBeventConfigurationsUiclassBeventDetails
                                    .Where(x => x.UiclassBeventConfigurationsUiclassBeventDetail != null && ids.Contains((Guid)x.UiclassBeventConfigurationsUiclassBeventDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiclassBeventConfigurationsUiclassBeventDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiclassBeventConfigurationsUiclassBeventDetails);
                    });
            
        }
    }
}
            
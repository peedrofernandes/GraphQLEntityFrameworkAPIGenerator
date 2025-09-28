
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
    public partial class HmiexpansionBoardConfigurationGraphType : ObjectGraphType<HmiexpansionBoardConfiguration>
    {
        public HmiexpansionBoardConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.HmiexpansionBoardConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<DisplayGraphType, Display>("Displays")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DisplayGraphType>>(
                            "{ Name = EntityName "HmiexpansionBoardConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "HmiexpansionBoardConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "HmiexpansionBoardConfigurationId"
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
         Navigation { Type = TableName "Display"
                      Name = "Displays"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "HmiexpansionBoardConfigurationsDisplay"
                      Name = "HmiexpansionBoardConfigurationsDisplays"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "HmiexpansionBoardConfigurationId"
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
   [OneToMany
      { Name = RelationName "Display"
        TargetTable =
         { Name = TableName "Display"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DisplayId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
                                                           Name = "Timestamp"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "GenericInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "FunctionConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SequenceConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "VisualBoardTypeId"
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
             ForeignKey { Type = Guid
                          Name = "StatusVariablesId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiledGroupsConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiaudioConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UianimationConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "HmiexpansionBoardConfigurationsId"
                          IsNullable = true }; ForeignKey { Type = Byte
                                                            Name = "BrandId"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UisreventConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiviewEngineControlStateConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiviewEngineViewsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UidataModelTranslationConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UitouchDevicesId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UilowPowerTimeId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UidefaultPinConfigurationId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "ProductVariant"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NodeAddress"
                                                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "FaultF12timeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StandByTimeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "GoingToSleepTimeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StandByCommunicationTimeout"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "MainTimeToEnd"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "DebugPointerConfigurationsId"
                          IsNullable = true };
             Navigation { Type = TableName "Brand"
                          Name = "Brand"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebugPointerConfiguration"
                          Name = "DebugPointerConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "FunctionConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "GenericInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HmiexpansionBoardConfiguration"
                          Name = "HmiexpansionBoardConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "HmiexpansionBoardConfigurationsDisplay"
                 Name = "HmiexpansionBoardConfigurationsDisplays"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HmiAvailableNode"
                          Name = "NodeAddressNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingProductVariant"
                          Name = "ProductVariantNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "SequenceConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationConfiguration"
                          Name = "UianimationConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiaudioConfiguration"
                          Name = "UiaudioConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UidataModelTranslationConfiguration"
                          Name = "UidataModelTranslationConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UidefaultPinConfiguration"
                          Name = "UidefaultPinConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiledGroupsConfiguration"
                          Name = "UiledGroupsConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UilowPowerTime"
                          Name = "UilowPowerTime"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UitouchDevice"
                          Name = "UitouchDevices"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "UiviewEngineControlStateConfiguration"
                 Name = "UiviewEngineControlStateConfigurations"
                 IsNullable = true
                 IsCollection = false };
             Navigation { Type = TableName "UiviewEngineViewsConfiguratio"
                          Name = "UiviewEngineViews"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Display"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "HmiexpansionBoardConfigurationsDisplay"
        TargetTable =
         { Name = TableName "HmiexpansionBoardConfigurationsDisplay"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "HmiexpansionBoardConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "DisplayId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "HmiexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "Display"
                          Name = "Display"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "HmiexpansionBoardConfiguration"
                          Name = "HmiexpansionBoardConfiguration"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "HmiexpansionBoardConfigurationsDisplay"
        KeyType = Guid }] }-Display-loader",
                            async ids => 
                            {
                                var data = await dbContext.Displays
                                    .Where(x => x.Display != null && ids.Contains((Guid)x.Display))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Display!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.Displays);
                    });
            
			
                Field<HmiexpansionBoardConfigurationsDisplayGraphType, HmiexpansionBoardConfigurationsDisplay>("HmiexpansionBoardConfigurationsDisplays")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<HmiexpansionBoardConfigurationsDisplayGraphType>>(
                            "{ Name = EntityName "HmiexpansionBoardConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "HmiexpansionBoardConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "HmiexpansionBoardConfigurationId"
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
         Navigation { Type = TableName "Display"
                      Name = "Displays"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "HmiexpansionBoardConfigurationsDisplay"
                      Name = "HmiexpansionBoardConfigurationsDisplays"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "HmiexpansionBoardConfigurationId"
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
   [OneToMany
      { Name = RelationName "Display"
        TargetTable =
         { Name = TableName "Display"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DisplayId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
                                                           Name = "Timestamp"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "GenericInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "FunctionConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "SequenceConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "VisualBoardTypeId"
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
             ForeignKey { Type = Guid
                          Name = "StatusVariablesId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiledGroupsConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiaudioConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UianimationConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "HmiexpansionBoardConfigurationsId"
                          IsNullable = true }; ForeignKey { Type = Byte
                                                            Name = "BrandId"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UisreventConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiviewEngineControlStateConfigurationsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiviewEngineViewsId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UidataModelTranslationConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UitouchDevicesId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UilowPowerTimeId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UidefaultPinConfigurationId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "ProductVariant"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NodeAddress"
                                                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "FaultF12timeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StandByTimeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "GoingToSleepTimeout"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "StandByCommunicationTimeout"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "MainTimeToEnd"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "DebugPointerConfigurationsId"
                          IsNullable = true };
             Navigation { Type = TableName "Brand"
                          Name = "Brand"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebugPointerConfiguration"
                          Name = "DebugPointerConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "FunctionConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "GenericInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HmiexpansionBoardConfiguration"
                          Name = "HmiexpansionBoardConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "HmiexpansionBoardConfigurationsDisplay"
                 Name = "HmiexpansionBoardConfigurationsDisplays"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "HmiAvailableNode"
                          Name = "NodeAddressNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingProductVariant"
                          Name = "ProductVariantNavigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "SequenceConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "StatusVariable"
                          Name = "StatusVariables"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationConfiguration"
                          Name = "UianimationConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiaudioConfiguration"
                          Name = "UiaudioConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UidataModelTranslationConfiguration"
                          Name = "UidataModelTranslationConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UidefaultPinConfiguration"
                          Name = "UidefaultPinConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UiledGroupsConfiguration"
                          Name = "UiledGroupsConfigurations"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UilowPowerTime"
                          Name = "UilowPowerTime"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UisreventConfiguration"
                          Name = "UisreventConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "UitouchDevice"
                          Name = "UitouchDevices"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "UiviewEngineControlStateConfiguration"
                 Name = "UiviewEngineControlStateConfigurations"
                 IsNullable = true
                 IsCollection = false };
             Navigation { Type = TableName "UiviewEngineViewsConfiguratio"
                          Name = "UiviewEngineViews"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "VisualBoardType"
                          Name = "VisualBoardType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Display"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "HmiexpansionBoardConfigurationsDisplay"
        TargetTable =
         { Name = TableName "HmiexpansionBoardConfigurationsDisplay"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "HmiexpansionBoardConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "DisplayId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "HmiexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "Display"
                          Name = "Display"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "HmiexpansionBoardConfiguration"
                          Name = "HmiexpansionBoardConfiguration"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "HmiexpansionBoardConfigurationsDisplay"
        KeyType = Guid }] }-HmiexpansionBoardConfigurationsDisplay-loader",
                            async ids => 
                            {
                                var data = await dbContext.HmiexpansionBoardConfigurationsDisplays
                                    .Where(x => x.HmiexpansionBoardConfigurationsDisplay != null && ids.Contains((Guid)x.HmiexpansionBoardConfigurationsDisplay))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.HmiexpansionBoardConfigurationsDisplay!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.HmiexpansionBoardConfigurationsDisplays);
                    });
            
        }
    }
}
            
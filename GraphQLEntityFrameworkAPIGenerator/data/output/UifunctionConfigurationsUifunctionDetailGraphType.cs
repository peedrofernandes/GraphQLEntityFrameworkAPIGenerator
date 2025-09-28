
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
    public partial class UifunctionConfigurationsUifunctionDetailGraphType : ObjectGraphType<UifunctionConfigurationsUifunctionDetail>
    {
        public UifunctionConfigurationsUifunctionDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UifunctionConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UifunctionDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.GireadTypePosition, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.FunctionLabel, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Compulsory, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Monitored, type: typeof(BoolGraphType), nullable: False);
            
                Field<FunctionLabelGraphType, FunctionLabel>("FunctionLabels")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, FunctionLabelGraphType>(
                            "{ Name = EntityName "UifunctionConfigurationsUifunctionDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UifunctionConfigurationsUifunctionDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UifunctionConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UifunctionDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "GireadTypeId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "GireadTypePosition"
                     IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UiregulationTableId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "FunctionLabel"
                                                       IsNullable = true };
         Primitive { Type = Bool
                     Name = "Compulsory"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Monitored"
                                                       IsNullable = false };
         Navigation { Type = TableName "FunctionLabel"
                      Name = "FunctionLabelNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UifunctionConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionDetail"
                      Name = "UifunctionDetail"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiregulationTable"
                      Name = "UiregulationTable"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "UifunctionConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UifunctionDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "GireadTypePosition"
      Type = Primitive Byte
      IsNullable = true }; { Name = "FunctionLabel"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "Compulsory"
                                                    Type = Primitive Bool
                                                    IsNullable = false };
    { Name = "Monitored"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FunctionLabel"
        TargetTable =
         { Name = TableName "FunctionLabel"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "FunctionLabelId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "FunctionLabel1"
                         IsNullable = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "FunctionLabel"
        IsNullable = true
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "UifunctionConfiguration"
        TargetTable =
         { Name = TableName "UifunctionConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionConfigurationId"
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
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Level"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UifunctionConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UifunctionDetail"
        TargetTable =
         { Name = TableName "UifunctionDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionDetailId"
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
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "FunctionId"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "TargetId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "ToMainBoard"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionFlags"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "RegulationFlags"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "SlaveInputTypeId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "SlaveInputTypePosition"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "IgnoreVisualRegulationTable"
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
                         Name = "FactoryRestoreIndex"
                         IsNullable = false };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UifunctionDetail"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiregulationTable"
        TargetTable =
         { Name = TableName "UiregulationTable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiregulationTableId"
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
             Primitive { Type = Bool
                         Name = "StepRegulation"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "RegulationNum"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "MainDataType"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "VisualDataType"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "MainInitialValue"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "VisualInitialValue"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "MainStep"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "VisualStep"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiregulationTable"
        IsNullable = true
        KeyType = Guid }] }-FunctionLabel-loader",
                            async ids => 
                            {
                                var data = await dbContext.FunctionLabels
                                    .Where(x => x.FunctionLabel != null && ids.Contains((byte)x.FunctionLabel))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.FunctionLabel!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.FunctionLabel);
                });
            
			
                Field<UifunctionConfigurationGraphType, UifunctionConfiguration>("UifunctionConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UifunctionConfigurationGraphType>(
                            "{ Name = EntityName "UifunctionConfigurationsUifunctionDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UifunctionConfigurationsUifunctionDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UifunctionConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UifunctionDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "GireadTypeId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "GireadTypePosition"
                     IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UiregulationTableId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "FunctionLabel"
                                                       IsNullable = true };
         Primitive { Type = Bool
                     Name = "Compulsory"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Monitored"
                                                       IsNullable = false };
         Navigation { Type = TableName "FunctionLabel"
                      Name = "FunctionLabelNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UifunctionConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionDetail"
                      Name = "UifunctionDetail"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiregulationTable"
                      Name = "UiregulationTable"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "UifunctionConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UifunctionDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "GireadTypePosition"
      Type = Primitive Byte
      IsNullable = true }; { Name = "FunctionLabel"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "Compulsory"
                                                    Type = Primitive Bool
                                                    IsNullable = false };
    { Name = "Monitored"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FunctionLabel"
        TargetTable =
         { Name = TableName "FunctionLabel"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "FunctionLabelId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "FunctionLabel1"
                         IsNullable = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "FunctionLabel"
        IsNullable = true
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "UifunctionConfiguration"
        TargetTable =
         { Name = TableName "UifunctionConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionConfigurationId"
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
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Level"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UifunctionConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UifunctionDetail"
        TargetTable =
         { Name = TableName "UifunctionDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionDetailId"
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
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "FunctionId"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "TargetId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "ToMainBoard"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionFlags"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "RegulationFlags"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "SlaveInputTypeId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "SlaveInputTypePosition"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "IgnoreVisualRegulationTable"
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
                         Name = "FactoryRestoreIndex"
                         IsNullable = false };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UifunctionDetail"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiregulationTable"
        TargetTable =
         { Name = TableName "UiregulationTable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiregulationTableId"
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
             Primitive { Type = Bool
                         Name = "StepRegulation"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "RegulationNum"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "MainDataType"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "VisualDataType"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "MainInitialValue"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "VisualInitialValue"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "MainStep"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "VisualStep"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiregulationTable"
        IsNullable = true
        KeyType = Guid }] }-UifunctionConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UifunctionConfigurations
                                    .Where(x => x.UifunctionConfiguration != null && ids.Contains((Guid)x.UifunctionConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UifunctionConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UifunctionConfiguration);
                });
            
			
                Field<UifunctionDetailGraphType, UifunctionDetail>("UifunctionDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UifunctionDetailGraphType>(
                            "{ Name = EntityName "UifunctionConfigurationsUifunctionDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UifunctionConfigurationsUifunctionDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UifunctionConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UifunctionDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "GireadTypeId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "GireadTypePosition"
                     IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UiregulationTableId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "FunctionLabel"
                                                       IsNullable = true };
         Primitive { Type = Bool
                     Name = "Compulsory"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Monitored"
                                                       IsNullable = false };
         Navigation { Type = TableName "FunctionLabel"
                      Name = "FunctionLabelNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UifunctionConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionDetail"
                      Name = "UifunctionDetail"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiregulationTable"
                      Name = "UiregulationTable"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "UifunctionConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UifunctionDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "GireadTypePosition"
      Type = Primitive Byte
      IsNullable = true }; { Name = "FunctionLabel"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "Compulsory"
                                                    Type = Primitive Bool
                                                    IsNullable = false };
    { Name = "Monitored"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FunctionLabel"
        TargetTable =
         { Name = TableName "FunctionLabel"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "FunctionLabelId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "FunctionLabel1"
                         IsNullable = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "FunctionLabel"
        IsNullable = true
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "UifunctionConfiguration"
        TargetTable =
         { Name = TableName "UifunctionConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionConfigurationId"
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
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Level"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UifunctionConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UifunctionDetail"
        TargetTable =
         { Name = TableName "UifunctionDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionDetailId"
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
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "FunctionId"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "TargetId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "ToMainBoard"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionFlags"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "RegulationFlags"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "SlaveInputTypeId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "SlaveInputTypePosition"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "IgnoreVisualRegulationTable"
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
                         Name = "FactoryRestoreIndex"
                         IsNullable = false };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UifunctionDetail"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiregulationTable"
        TargetTable =
         { Name = TableName "UiregulationTable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiregulationTableId"
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
             Primitive { Type = Bool
                         Name = "StepRegulation"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "RegulationNum"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "MainDataType"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "VisualDataType"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "MainInitialValue"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "VisualInitialValue"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "MainStep"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "VisualStep"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiregulationTable"
        IsNullable = true
        KeyType = Guid }] }-UifunctionDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UifunctionDetails
                                    .Where(x => x.UifunctionDetail != null && ids.Contains((Guid)x.UifunctionDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UifunctionDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UifunctionDetail);
                });
            
			
                Field<UiregulationTableGraphType, UiregulationTable>("UiregulationTables")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiregulationTableGraphType>(
                            "{ Name = EntityName "UifunctionConfigurationsUifunctionDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UifunctionConfigurationsUifunctionDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UifunctionConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UifunctionDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "GireadTypeId"
                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "GireadTypePosition"
                     IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UiregulationTableId"
                      IsNullable = true }; Primitive { Type = Byte
                                                       Name = "FunctionLabel"
                                                       IsNullable = true };
         Primitive { Type = Bool
                     Name = "Compulsory"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Monitored"
                                                       IsNullable = false };
         Navigation { Type = TableName "FunctionLabel"
                      Name = "FunctionLabelNavigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionConfiguration"
                      Name = "UifunctionConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UifunctionDetail"
                      Name = "UifunctionDetail"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiregulationTable"
                      Name = "UiregulationTable"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "UifunctionConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UifunctionDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "GireadTypePosition"
      Type = Primitive Byte
      IsNullable = true }; { Name = "FunctionLabel"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "Compulsory"
                                                    Type = Primitive Bool
                                                    IsNullable = false };
    { Name = "Monitored"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "FunctionLabel"
        TargetTable =
         { Name = TableName "FunctionLabel"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "FunctionLabelId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "FunctionLabel1"
                         IsNullable = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "FunctionLabel"
        IsNullable = true
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "UifunctionConfiguration"
        TargetTable =
         { Name = TableName "UifunctionConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionConfigurationId"
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
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Level"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfiguration"
                          Name = "SelectorConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UifunctionConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UifunctionDetail"
        TargetTable =
         { Name = TableName "UifunctionDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UifunctionDetailId"
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
                         IsNullable = false }; ForeignKey { Type = Byte
                                                            Name = "FunctionId"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "TargetId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "ToMainBoard"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "FunctionFlags"
                         IsNullable = false };
             Primitive { Type = Int
                         Name = "RegulationFlags"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "SlaveInputTypeId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "SlaveInputTypePosition"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "IgnoreVisualRegulationTable"
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
                         Name = "FactoryRestoreIndex"
                         IsNullable = false };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UifunctionDetail"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiregulationTable"
        TargetTable =
         { Name = TableName "UiregulationTable"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiregulationTableId"
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
             Primitive { Type = Bool
                         Name = "StepRegulation"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "RegulationNum"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "MainDataType"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "VisualDataType"
                         IsNullable = false };
             Primitive { Type = Double
                         Name = "MainInitialValue"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "VisualInitialValue"
                         IsNullable = false }; Primitive { Type = Double
                                                           Name = "MainStep"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "VisualStep"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UifunctionConfigurationsUifunctionDetail"
                 Name = "UifunctionConfigurationsUifunctionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UiregulationTable"
        IsNullable = true
        KeyType = Guid }] }-UiregulationTable-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiregulationTables
                                    .Where(x => x.UiregulationTable != null && ids.Contains((Guid)x.UiregulationTable))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiregulationTable!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiregulationTable);
                });
            
        }
    }
}
            

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
    public partial class CycleMappingCycleOptionsConfigurationGraphType : ObjectGraphType<CycleMappingCycleOptionsConfiguration>
    {
        public CycleMappingCycleOptionsConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleMappingId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CycleOptionsConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CycleName, type: typeof(IdGraphType), nullable: True);
			Field(t => t.HmiCycleName, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ConnectivityCycleEnumeration0, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Compartment0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ConnectivityCycleKey0, type: typeof(LongGraphType), nullable: True);
			Field(t => t.SetCycleTreeLevels, type: typeof(ByteGraphType), nullable: True);
            
                Field<CycleMappingGraphType, CycleMapping>("CycleMappings")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleMappingGraphType>(
                            "{ Name = EntityName "CycleMappingCycleOptionsConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleMappingCycleOptionsConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleMappingId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CycleOptionsConfigurationsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Primitive { Type = Int
                     Name = "CycleName"
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "HmiCycleName"
                                                      IsNullable = true };
         Primitive { Type = Int
                     Name = "ConnectivityCycleEnumeration0"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Compartment0"
                                                      IsNullable = false };
         Primitive { Type = Long
                     Name = "ConnectivityCycleKey0"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "SetCycleTreeLevels"
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "UriTreeId"
                                                       IsNullable = true };
         Navigation { Type = TableName "CycleMapping"
                      Name = "CycleMapping"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleOptionsConfiguration"
                      Name = "CycleOptionsConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleMappingUri"
                      Name = "UriTree"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleMappingId"
      Type = Id Guid
      IsNullable = false }; { Name = "CycleOptionsConfigurationsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "CycleName"
      Type = Primitive Int
      IsNullable = true }; { Name = "HmiCycleName"
                             Type = Primitive String
                             IsNullable = true };
    { Name = "ConnectivityCycleEnumeration0"
      Type = Primitive Int
      IsNullable = true }; { Name = "Compartment0"
                             Type = Primitive Byte
                             IsNullable = false };
    { Name = "ConnectivityCycleKey0"
      Type = Primitive Long
      IsNullable = true }; { Name = "SetCycleTreeLevels"
                             Type = Primitive Byte
                             IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleMapping"
        TargetTable =
         { Name = TableName "CycleMapping"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingId"
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
             ForeignKey { Type = Byte
                          Name = "ExportOptionId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsConnected"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "DataModelVersion"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "Version"
                                                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CycleMappingFileInfoId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CycleMappingAcuTargetId"
                          IsNullable = true };
             Navigation { Type = TableName "CycleMappingAcuTarget"
                          Name = "CycleMappingAcuTarget"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CycleMappingFileInfo"
                          Name = "CycleMappingFileInfo"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingExportOption"
                          Name = "ExportOption"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleMapping"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleOptionsConfiguration"
        TargetTable =
         { Name = TableName "CycleOptionsConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleOptionsConfigurationsId"
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
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
                 Name = "CycleOptionsConfigurationsCycleOptionsDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleOptionsConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleMappingUri"
        TargetTable =
         { Name = TableName "CycleMappingUri"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UriTreeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfTrees"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels4"
                         IsNullable = true };
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleMappingUri"
        IsNullable = true
        KeyType = Guid }] }-CycleMapping-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleMappings
                                    .Where(x => x.CycleMapping != null && ids.Contains((Guid)x.CycleMapping))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleMapping!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleMapping);
                });
            
			
                Field<CycleOptionsConfigurationGraphType, CycleOptionsConfiguration>("CycleOptionsConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleOptionsConfigurationGraphType>(
                            "{ Name = EntityName "CycleMappingCycleOptionsConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleMappingCycleOptionsConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleMappingId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CycleOptionsConfigurationsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Primitive { Type = Int
                     Name = "CycleName"
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "HmiCycleName"
                                                      IsNullable = true };
         Primitive { Type = Int
                     Name = "ConnectivityCycleEnumeration0"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Compartment0"
                                                      IsNullable = false };
         Primitive { Type = Long
                     Name = "ConnectivityCycleKey0"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "SetCycleTreeLevels"
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "UriTreeId"
                                                       IsNullable = true };
         Navigation { Type = TableName "CycleMapping"
                      Name = "CycleMapping"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleOptionsConfiguration"
                      Name = "CycleOptionsConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleMappingUri"
                      Name = "UriTree"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleMappingId"
      Type = Id Guid
      IsNullable = false }; { Name = "CycleOptionsConfigurationsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "CycleName"
      Type = Primitive Int
      IsNullable = true }; { Name = "HmiCycleName"
                             Type = Primitive String
                             IsNullable = true };
    { Name = "ConnectivityCycleEnumeration0"
      Type = Primitive Int
      IsNullable = true }; { Name = "Compartment0"
                             Type = Primitive Byte
                             IsNullable = false };
    { Name = "ConnectivityCycleKey0"
      Type = Primitive Long
      IsNullable = true }; { Name = "SetCycleTreeLevels"
                             Type = Primitive Byte
                             IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleMapping"
        TargetTable =
         { Name = TableName "CycleMapping"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingId"
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
             ForeignKey { Type = Byte
                          Name = "ExportOptionId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsConnected"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "DataModelVersion"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "Version"
                                                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CycleMappingFileInfoId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CycleMappingAcuTargetId"
                          IsNullable = true };
             Navigation { Type = TableName "CycleMappingAcuTarget"
                          Name = "CycleMappingAcuTarget"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CycleMappingFileInfo"
                          Name = "CycleMappingFileInfo"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingExportOption"
                          Name = "ExportOption"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleMapping"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleOptionsConfiguration"
        TargetTable =
         { Name = TableName "CycleOptionsConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleOptionsConfigurationsId"
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
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
                 Name = "CycleOptionsConfigurationsCycleOptionsDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleOptionsConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleMappingUri"
        TargetTable =
         { Name = TableName "CycleMappingUri"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UriTreeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfTrees"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels4"
                         IsNullable = true };
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleMappingUri"
        IsNullable = true
        KeyType = Guid }] }-CycleOptionsConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleOptionsConfigurations
                                    .Where(x => x.CycleOptionsConfiguration != null && ids.Contains((Guid)x.CycleOptionsConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleOptionsConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleOptionsConfiguration);
                });
            
			
                Field<CycleMappingUriGraphType, CycleMappingUri>("CycleMappingUris")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleMappingUriGraphType>(
                            "{ Name = EntityName "CycleMappingCycleOptionsConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleMappingCycleOptionsConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleMappingId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CycleOptionsConfigurationsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Primitive { Type = Int
                     Name = "CycleName"
                     IsNullable = true }; Primitive { Type = String
                                                      Name = "HmiCycleName"
                                                      IsNullable = true };
         Primitive { Type = Int
                     Name = "ConnectivityCycleEnumeration0"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Compartment0"
                                                      IsNullable = false };
         Primitive { Type = Long
                     Name = "ConnectivityCycleKey0"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "SetCycleTreeLevels"
                     IsNullable = true }; ForeignKey { Type = Guid
                                                       Name = "UriTreeId"
                                                       IsNullable = true };
         Navigation { Type = TableName "CycleMapping"
                      Name = "CycleMapping"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleOptionsConfiguration"
                      Name = "CycleOptionsConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleMappingUri"
                      Name = "UriTree"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "CycleMappingId"
      Type = Id Guid
      IsNullable = false }; { Name = "CycleOptionsConfigurationsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false };
    { Name = "CycleName"
      Type = Primitive Int
      IsNullable = true }; { Name = "HmiCycleName"
                             Type = Primitive String
                             IsNullable = true };
    { Name = "ConnectivityCycleEnumeration0"
      Type = Primitive Int
      IsNullable = true }; { Name = "Compartment0"
                             Type = Primitive Byte
                             IsNullable = false };
    { Name = "ConnectivityCycleKey0"
      Type = Primitive Long
      IsNullable = true }; { Name = "SetCycleTreeLevels"
                             Type = Primitive Byte
                             IsNullable = true }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleMapping"
        TargetTable =
         { Name = TableName "CycleMapping"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingId"
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
             ForeignKey { Type = Byte
                          Name = "ExportOptionId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsConnected"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "DataModelVersion"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "Version"
                                                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CycleMappingFileInfoId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CycleMappingAcuTargetId"
                          IsNullable = true };
             Navigation { Type = TableName "CycleMappingAcuTarget"
                          Name = "CycleMappingAcuTarget"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CycleMappingFileInfo"
                          Name = "CycleMappingFileInfo"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingExportOption"
                          Name = "ExportOption"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleMapping"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleOptionsConfiguration"
        TargetTable =
         { Name = TableName "CycleOptionsConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleOptionsConfigurationsId"
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
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleOptionsConfigurationsCycleOptionsDetail"
                 Name = "CycleOptionsConfigurationsCycleOptionsDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleOptionsConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CycleMappingUri"
        TargetTable =
         { Name = TableName "CycleMappingUri"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UriTreeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfTrees"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels1"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels2"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels3"
                         IsNullable = true };
             Primitive { Type = Byte
                         Name = "SetCycleTreeLevels4"
                         IsNullable = true };
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleMappingUri"
        IsNullable = true
        KeyType = Guid }] }-CycleMappingUri-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleMappingUris
                                    .Where(x => x.CycleMappingUri != null && ids.Contains((Guid)x.CycleMappingUri))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleMappingUri!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleMappingUri);
                });
            
        }
    }
}
            
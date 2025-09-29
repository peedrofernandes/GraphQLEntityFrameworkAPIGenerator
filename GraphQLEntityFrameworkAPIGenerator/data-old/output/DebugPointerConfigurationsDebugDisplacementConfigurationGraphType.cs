
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
    public partial class DebugPointerConfigurationsDebugDisplacementConfigurationGraphType : ObjectGraphType<DebugPointerConfigurationsDebugDisplacementConfiguration>
    {
        public DebugPointerConfigurationsDebugDisplacementConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DebugPointerConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DebugDisplacementConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<DebugDisplacementConfigurationGraphType, DebugDisplacementConfiguration>("DebugDisplacementConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DebugDisplacementConfigurationGraphType>(
                            "{ Name = EntityName "DebugPointerConfigurationsDebugDisplacementConfiguration"
  CorrespondingTable =
   Regular
     { Name =
        TableName "DebugPointerConfigurationsDebugDisplacementConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DebugPointerConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "DebugDisplacementConfigurationsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "DebugDisplacementConfiguration"
                      Name = "DebugDisplacementConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "DebugPointerConfiguration"
                      Name = "DebugPointerConfigurations"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "DebugPointerConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "DebugDisplacementConfigurationsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DebugDisplacementConfiguration"
        TargetTable =
         { Name = TableName "DebugDisplacementConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebugDisplacementConfigurationsId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "FlagOneDataType"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "DataType"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
               { Type =
                  TableName "DebugDisplacementConfigurationsDebugDataDetail"
                 Name = "DebugDisplacementConfigurationsDebugDataDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "DebugPointerConfigurationsDebugDisplacementConfiguration"
                 Name =
                  "DebugPointerConfigurationsDebugDisplacementConfigurations"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DebugDisplacementConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DebugPointerConfiguration"
        TargetTable =
         { Name = TableName "DebugPointerConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebugPointerConfigurationsId"
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
               { Type =
                  TableName
                    "DebugPointerConfigurationsDebugDisplacementConfiguration"
                 Name =
                  "DebugPointerConfigurationsDebugDisplacementConfigurations"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Display"
                                                     Name = "Displays"
                                                     IsNullable = false
                                                     IsCollection = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "DebugPointerConfiguration"
        IsNullable = false
        KeyType = Guid }] }-DebugDisplacementConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.DebugDisplacementConfigurations
                                    .Where(x => x.DebugDisplacementConfiguration != null && ids.Contains((Guid)x.DebugDisplacementConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DebugDisplacementConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.DebugDisplacementConfiguration);
                });
            
			
                Field<DebugPointerConfigurationGraphType, DebugPointerConfiguration>("DebugPointerConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DebugPointerConfigurationGraphType>(
                            "{ Name = EntityName "DebugPointerConfigurationsDebugDisplacementConfiguration"
  CorrespondingTable =
   Regular
     { Name =
        TableName "DebugPointerConfigurationsDebugDisplacementConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DebugPointerConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "DebugDisplacementConfigurationsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "DebugDisplacementConfiguration"
                      Name = "DebugDisplacementConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "DebugPointerConfiguration"
                      Name = "DebugPointerConfigurations"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "DebugPointerConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "DebugDisplacementConfigurationsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DebugDisplacementConfiguration"
        TargetTable =
         { Name = TableName "DebugDisplacementConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebugDisplacementConfigurationsId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "FlagOneDataType"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "DataType"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
               { Type =
                  TableName "DebugDisplacementConfigurationsDebugDataDetail"
                 Name = "DebugDisplacementConfigurationsDebugDataDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "DebugPointerConfigurationsDebugDisplacementConfiguration"
                 Name =
                  "DebugPointerConfigurationsDebugDisplacementConfigurations"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DebugDisplacementConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DebugPointerConfiguration"
        TargetTable =
         { Name = TableName "DebugPointerConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebugPointerConfigurationsId"
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
               { Type =
                  TableName
                    "DebugPointerConfigurationsDebugDisplacementConfiguration"
                 Name =
                  "DebugPointerConfigurationsDebugDisplacementConfigurations"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Display"
                                                     Name = "Displays"
                                                     IsNullable = false
                                                     IsCollection = true };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "DebugPointerConfiguration"
        IsNullable = false
        KeyType = Guid }] }-DebugPointerConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.DebugPointerConfigurations
                                    .Where(x => x.DebugPointerConfiguration != null && ids.Contains((Guid)x.DebugPointerConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DebugPointerConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.DebugPointerConfiguration);
                });
            
        }
    }
}
            
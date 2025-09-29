
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
    public partial class DebugDisplacementConfigurationsDebugDataDetailGraphType : ObjectGraphType<DebugDisplacementConfigurationsDebugDataDetail>
    {
        public DebugDisplacementConfigurationsDebugDataDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DebugDisplacementConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DebugDataDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<DebugDataDetailGraphType, DebugDataDetail>("DebugDataDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DebugDataDetailGraphType>(
                            "{ Name = EntityName "DebugDisplacementConfigurationsDebugDataDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "DebugDisplacementConfigurationsDebugDataDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DebugDisplacementConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "DebugDataDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "DebugDataDetail"
                      Name = "DebugDataDetails"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "DebugDisplacementConfiguration"
                      Name = "DebugDisplacementConfigurations"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "DebugDisplacementConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "DebugDataDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DebugDataDetail"
        TargetTable =
         { Name = TableName "DebugDataDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebugDataDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "DataType"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "DataValue"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName "DebugDisplacementConfigurationsDebugDataDetail"
                 Name = "DebugDisplacementConfigurationsDebugDataDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DebugDataDetail"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
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
        KeyType = Guid }] }-DebugDataDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.DebugDataDetails
                                    .Where(x => x.DebugDataDetail != null && ids.Contains((Guid)x.DebugDataDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DebugDataDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.DebugDataDetail);
                });
            
			
                Field<DebugDisplacementConfigurationGraphType, DebugDisplacementConfiguration>("DebugDisplacementConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DebugDisplacementConfigurationGraphType>(
                            "{ Name = EntityName "DebugDisplacementConfigurationsDebugDataDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "DebugDisplacementConfigurationsDebugDataDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DebugDisplacementConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "DebugDataDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "DebugDataDetail"
                      Name = "DebugDataDetails"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "DebugDisplacementConfiguration"
                      Name = "DebugDisplacementConfigurations"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "DebugDisplacementConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "DebugDataDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DebugDataDetail"
        TargetTable =
         { Name = TableName "DebugDataDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebugDataDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "DataType"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "DataValue"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName "DebugDisplacementConfigurationsDebugDataDetail"
                 Name = "DebugDisplacementConfigurationsDebugDataDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DebugDataDetail"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
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
            
        }
    }
}
            
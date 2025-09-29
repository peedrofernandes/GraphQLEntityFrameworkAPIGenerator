
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
    public partial class CrossLoadConfigurationsCrossLoadDetailGraphType : ObjectGraphType<CrossLoadConfigurationsCrossLoadDetail>
    {
        public CrossLoadConfigurationsCrossLoadDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CrossLoadConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.CrossLoadDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<CrossLoadConfigurationGraphType, CrossLoadConfiguration>("CrossLoadConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CrossLoadConfigurationGraphType>(
                            "{ Name = EntityName "CrossLoadConfigurationsCrossLoadDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "CrossLoadConfigurationsCrossLoadDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CrossLoadConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CrossLoadDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "CrossLoadConfiguration"
                      Name = "CrossLoadConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CrossLoadDetail"
                      Name = "CrossLoadDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CrossLoadConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "CrossLoadDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CrossLoadConfiguration"
        TargetTable =
         { Name = TableName "CrossLoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadDetail"
        TargetTable =
         { Name = TableName "CrossLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "CrossLoadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "OnDelayTime"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "OffDelayTime"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CouplesNum"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOnDisconnected"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOffDisconnected"
                         IsNullable = false };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CrossLoadType"
                          Name = "CrossLoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadDetail"
        IsNullable = false
        KeyType = Guid }] }-CrossLoadConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.CrossLoadConfigurations
                                    .Where(x => x.CrossLoadConfiguration != null && ids.Contains((Guid)x.CrossLoadConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CrossLoadConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CrossLoadConfiguration);
                });
            
			
                Field<CrossLoadDetailGraphType, CrossLoadDetail>("CrossLoadDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CrossLoadDetailGraphType>(
                            "{ Name = EntityName "CrossLoadConfigurationsCrossLoadDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "CrossLoadConfigurationsCrossLoadDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CrossLoadConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "CrossLoadDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "CrossLoadConfiguration"
                      Name = "CrossLoadConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CrossLoadDetail"
                      Name = "CrossLoadDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CrossLoadConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "CrossLoadDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CrossLoadConfiguration"
        TargetTable =
         { Name = TableName "CrossLoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
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
             Navigation { Type = TableName "Board"
                          Name = "Boards"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadDetail"
        TargetTable =
         { Name = TableName "CrossLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "CrossLoadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "OnDelayTime"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "OffDelayTime"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "CouplesNum"
                                                           IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOnDisconnected"
                         IsNullable = false };
             Primitive { Type = Short
                         Name = "LoadOffDisconnected"
                         IsNullable = false };
             Navigation
               { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                 Name = "CrossLoadConfigurationsCrossLoadDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CrossLoadType"
                          Name = "CrossLoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadDetail"
        IsNullable = false
        KeyType = Guid }] }-CrossLoadDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.CrossLoadDetails
                                    .Where(x => x.CrossLoadDetail != null && ids.Contains((Guid)x.CrossLoadDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CrossLoadDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CrossLoadDetail);
                });
            
        }
    }
}
            
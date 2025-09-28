
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
    public partial class PrmLoadFanConfigurationPrmLoadFanDetailGraphType : ObjectGraphType<PrmLoadFanConfigurationPrmLoadFanDetail>
    {
        public PrmLoadFanConfigurationPrmLoadFanDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrmLoadFanDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrmLoadFanConfigurationGraphType, PrmLoadFanConfiguration>("PrmLoadFanConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrmLoadFanConfigurationGraphType>(
                            "{ Name = EntityName "PrmLoadFanConfigurationPrmLoadFanDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PrmLoadFanConfigurationPrmLoadFanDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrmLoadFanDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrmLoadFanConfiguration"
                      Name = "IdNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PrmLoadFanDetail"
                      Name = "PrmLoadFanDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "PrmLoadFanDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrmLoadFanConfiguration"
        TargetTable =
         { Name = TableName "PrmLoadFanConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "FanType"
                         IsNullable = false };
             Navigation
               { Type = TableName "PrmLoadFanConfigurationPrmLoadFanDetail"
                 Name = "PrmLoadFanConfigurationPrmLoadFanDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrmLoadFanConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrmLoadFanDetail"
        TargetTable =
         { Name = TableName "PrmLoadFanDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrmLoadFanDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "K1value"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "K2value"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "K3value"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "K4value"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerPercentage"
                         IsNullable = false };
             Navigation
               { Type = TableName "PrmLoadFanConfigurationPrmLoadFanDetail"
                 Name = "PrmLoadFanConfigurationPrmLoadFanDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrmLoadFanDetail"
        IsNullable = false
        KeyType = Guid }] }-PrmLoadFanConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrmLoadFanConfigurations
                                    .Where(x => x.PrmLoadFanConfiguration != null && ids.Contains((Guid)x.PrmLoadFanConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrmLoadFanConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrmLoadFanConfiguration);
                });
            
			
                Field<PrmLoadFanDetailGraphType, PrmLoadFanDetail>("PrmLoadFanDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrmLoadFanDetailGraphType>(
                            "{ Name = EntityName "PrmLoadFanConfigurationPrmLoadFanDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PrmLoadFanConfigurationPrmLoadFanDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrmLoadFanDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrmLoadFanConfiguration"
                      Name = "IdNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PrmLoadFanDetail"
                      Name = "PrmLoadFanDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "PrmLoadFanDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrmLoadFanConfiguration"
        TargetTable =
         { Name = TableName "PrmLoadFanConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "FanType"
                         IsNullable = false };
             Navigation
               { Type = TableName "PrmLoadFanConfigurationPrmLoadFanDetail"
                 Name = "PrmLoadFanConfigurationPrmLoadFanDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrmLoadFanConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrmLoadFanDetail"
        TargetTable =
         { Name = TableName "PrmLoadFanDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrmLoadFanDetailsId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "K1value"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "K2value"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "K3value"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "K4value"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "PowerPercentage"
                         IsNullable = false };
             Navigation
               { Type = TableName "PrmLoadFanConfigurationPrmLoadFanDetail"
                 Name = "PrmLoadFanConfigurationPrmLoadFanDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrmLoadFanDetail"
        IsNullable = false
        KeyType = Guid }] }-PrmLoadFanDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrmLoadFanDetails
                                    .Where(x => x.PrmLoadFanDetail != null && ids.Contains((Guid)x.PrmLoadFanDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrmLoadFanDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrmLoadFanDetail);
                });
            
        }
    }
}
            
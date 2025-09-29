
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
    public partial class UiaudioBuzzerUiaudioBuzzerDetailGraphType : ObjectGraphType<UiaudioBuzzerUiaudioBuzzerDetail>
    {
        public UiaudioBuzzerUiaudioBuzzerDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrmUiaudioBuzzerDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrmUiaudioBuzzerGraphType, PrmUiaudioBuzzer>("PrmUiaudioBuzzers")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrmUiaudioBuzzerGraphType>(
                            "{ Name = EntityName "UiaudioBuzzerUiaudioBuzzerDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiaudioBuzzerUiaudioBuzzerDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrmUiaudioBuzzerDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrmUiaudioBuzzer"
                      Name = "IdNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiaudioBuzzerDetail"
                      Name = "PrmUiaudioBuzzerDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "PrmUiaudioBuzzerDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrmUiaudioBuzzer"
        TargetTable =
         { Name = TableName "PrmUiaudioBuzzer"
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
                         Name = "ChimeIndex"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "NumRepeats"
                                                           IsNullable = false };
             Navigation { Type = TableName "UiaudioBuzzerUiaudioBuzzerDetail"
                          Name = "UiaudioBuzzerUiaudioBuzzerDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrmUiaudioBuzzer"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiaudioBuzzerDetail"
        TargetTable =
         { Name = TableName "UiaudioBuzzerDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrmUiaudioBuzzerDetailsId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Frequency"
                                                            IsNullable = false };
             Primitive { Type = Short
                         Name = "TimeOn"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "TimeOff"
                                                           IsNullable = false };
             Navigation { Type = TableName "UiaudioBuzzerUiaudioBuzzerDetail"
                          Name = "UiaudioBuzzerUiaudioBuzzerDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiaudioBuzzerDetail"
        IsNullable = false
        KeyType = Guid }] }-PrmUiaudioBuzzer-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrmUiaudioBuzzers
                                    .Where(x => x.PrmUiaudioBuzzer != null && ids.Contains((Guid)x.PrmUiaudioBuzzer))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrmUiaudioBuzzer!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrmUiaudioBuzzer);
                });
            
			
                Field<UiaudioBuzzerDetailGraphType, UiaudioBuzzerDetail>("UiaudioBuzzerDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiaudioBuzzerDetailGraphType>(
                            "{ Name = EntityName "UiaudioBuzzerUiaudioBuzzerDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiaudioBuzzerUiaudioBuzzerDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrmUiaudioBuzzerDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrmUiaudioBuzzer"
                      Name = "IdNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UiaudioBuzzerDetail"
                      Name = "PrmUiaudioBuzzerDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "PrmUiaudioBuzzerDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrmUiaudioBuzzer"
        TargetTable =
         { Name = TableName "PrmUiaudioBuzzer"
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
                         Name = "ChimeIndex"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "NumRepeats"
                                                           IsNullable = false };
             Navigation { Type = TableName "UiaudioBuzzerUiaudioBuzzerDetail"
                          Name = "UiaudioBuzzerUiaudioBuzzerDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PrmUiaudioBuzzer"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiaudioBuzzerDetail"
        TargetTable =
         { Name = TableName "UiaudioBuzzerDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrmUiaudioBuzzerDetailsId"
                          IsNullable = false }; Primitive { Type = Short
                                                            Name = "Frequency"
                                                            IsNullable = false };
             Primitive { Type = Short
                         Name = "TimeOn"
                         IsNullable = false }; Primitive { Type = Short
                                                           Name = "TimeOff"
                                                           IsNullable = false };
             Navigation { Type = TableName "UiaudioBuzzerUiaudioBuzzerDetail"
                          Name = "UiaudioBuzzerUiaudioBuzzerDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiaudioBuzzerDetail"
        IsNullable = false
        KeyType = Guid }] }-UiaudioBuzzerDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiaudioBuzzerDetails
                                    .Where(x => x.UiaudioBuzzerDetail != null && ids.Contains((Guid)x.UiaudioBuzzerDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiaudioBuzzerDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiaudioBuzzerDetail);
                });
            
        }
    }
}
            
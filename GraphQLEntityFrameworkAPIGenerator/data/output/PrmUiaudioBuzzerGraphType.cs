
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
    public partial class PrmUiaudioBuzzerGraphType : ObjectGraphType<PrmUiaudioBuzzer>
    {
        public PrmUiaudioBuzzerGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ChimeIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumRepeats, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiaudioBuzzerUiaudioBuzzerDetailGraphType, UiaudioBuzzerUiaudioBuzzerDetail>("UiaudioBuzzerUiaudioBuzzerDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiaudioBuzzerUiaudioBuzzerDetailGraphType>>(
                            "{ Name = EntityName "PrmUiaudioBuzzer"
  CorrespondingTable =
   Regular
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
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "ChimeIndex"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "NumRepeats"
                     IsNullable = false };
         Navigation { Type = TableName "UiaudioBuzzerUiaudioBuzzerDetail"
                      Name = "UiaudioBuzzerUiaudioBuzzerDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "Id"
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
                                                      IsNullable = true };
    { Name = "ChimeIndex"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NumRepeats"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UiaudioBuzzerUiaudioBuzzerDetail"
        TargetTable =
         { Name = TableName "UiaudioBuzzerUiaudioBuzzerDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrmUiaudioBuzzerDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination = EntityName "UiaudioBuzzerUiaudioBuzzerDetail"
        KeyType = Guid }] }-UiaudioBuzzerUiaudioBuzzerDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiaudioBuzzerUiaudioBuzzerDetails
                                    .Where(x => x.UiaudioBuzzerUiaudioBuzzerDetail != null && ids.Contains((Guid)x.UiaudioBuzzerUiaudioBuzzerDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiaudioBuzzerUiaudioBuzzerDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiaudioBuzzerUiaudioBuzzerDetails);
                    });
            
        }
    }
}
            
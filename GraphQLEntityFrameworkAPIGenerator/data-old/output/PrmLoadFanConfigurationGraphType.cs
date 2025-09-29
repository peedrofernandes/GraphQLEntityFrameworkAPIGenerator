
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
    public partial class PrmLoadFanConfigurationGraphType : ObjectGraphType<PrmLoadFanConfiguration>
    {
        public PrmLoadFanConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
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
			Field(t => t.FanType, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrmLoadFanConfigurationPrmLoadFanDetailGraphType, PrmLoadFanConfigurationPrmLoadFanDetail>("PrmLoadFanConfigurationPrmLoadFanDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmLoadFanConfigurationPrmLoadFanDetailGraphType>>(
                            "{ Name = EntityName "PrmLoadFanConfiguration"
  CorrespondingTable =
   Regular
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
                                                      Name = "FanType"
                                                      IsNullable = false };
         Navigation { Type = TableName "PrmLoadFanConfigurationPrmLoadFanDetail"
                      Name = "PrmLoadFanConfigurationPrmLoadFanDetails"
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
    { Name = "FanType"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PrmLoadFanConfigurationPrmLoadFanDetail"
        TargetTable =
         { Name = TableName "PrmLoadFanConfigurationPrmLoadFanDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrmLoadFanDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
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
        Destination = EntityName "PrmLoadFanConfigurationPrmLoadFanDetail"
        KeyType = Guid }] }-PrmLoadFanConfigurationPrmLoadFanDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrmLoadFanConfigurationPrmLoadFanDetails
                                    .Where(x => x.PrmLoadFanConfigurationPrmLoadFanDetail != null && ids.Contains((Guid)x.PrmLoadFanConfigurationPrmLoadFanDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrmLoadFanConfigurationPrmLoadFanDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrmLoadFanConfigurationPrmLoadFanDetails);
                    });
            
        }
    }
}
            
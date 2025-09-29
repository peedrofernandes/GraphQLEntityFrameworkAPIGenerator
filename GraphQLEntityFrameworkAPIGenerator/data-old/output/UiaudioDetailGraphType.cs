
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
    public partial class UiaudioDetailGraphType : ObjectGraphType<UiaudioDetail>
    {
        public UiaudioDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiaudioDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Name, type: typeof(StringGraphType), nullable: False);
			Field(t => t.DeviceType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DeviceIndex, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.AudioFunction, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AudioIndex, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiaudioConfigurationsUiaudioDetailGraphType, UiaudioConfigurationsUiaudioDetail>("UiaudioConfigurationsUiaudioDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UiaudioConfigurationsUiaudioDetailGraphType>>(
                            "{ Name = EntityName "UiaudioDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiaudioDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiaudioDetailsId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Primitive { Type = String
                     Name = "Name"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "DeviceType"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "DeviceIndex"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UiaudioDevicePrmId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Status"
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
         Primitive { Type = Short
                     Name = "AudioFunction"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Compartment"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "AudioIndex"
                     IsNullable = false };
         Navigation { Type = TableName "UiaudioConfigurationsUiaudioDetail"
                      Name = "UiaudioConfigurationsUiaudioDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "UiaudioDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Name"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "DeviceType"
      Type = Primitive Byte
      IsNullable = false }; { Name = "DeviceIndex"
                              Type = Primitive Byte
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
    { Name = "AudioFunction"
      Type = Primitive Short
      IsNullable = false }; { Name = "Compartment"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "AudioIndex"
                                                      Type = Primitive Byte
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UiaudioConfigurationsUiaudioDetail"
        TargetTable =
         { Name = TableName "UiaudioConfigurationsUiaudioDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiaudioConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UiaudioDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UiaudioConfiguration"
                          Name = "UiaudioConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UiaudioDetail"
                          Name = "UiaudioDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UiaudioConfigurationsUiaudioDetail"
        KeyType = Guid }] }-UiaudioConfigurationsUiaudioDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiaudioConfigurationsUiaudioDetails
                                    .Where(x => x.UiaudioConfigurationsUiaudioDetail != null && ids.Contains((Guid)x.UiaudioConfigurationsUiaudioDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiaudioConfigurationsUiaudioDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UiaudioConfigurationsUiaudioDetails);
                    });
            
        }
    }
}
            
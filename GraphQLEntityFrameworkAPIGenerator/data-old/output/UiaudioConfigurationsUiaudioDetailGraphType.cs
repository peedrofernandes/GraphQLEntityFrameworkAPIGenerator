
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
    public partial class UiaudioConfigurationsUiaudioDetailGraphType : ObjectGraphType<UiaudioConfigurationsUiaudioDetail>
    {
        public UiaudioConfigurationsUiaudioDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiaudioConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UiaudioDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiaudioConfigurationGraphType, UiaudioConfiguration>("UiaudioConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiaudioConfigurationGraphType>(
                            "{ Name = EntityName "UiaudioConfigurationsUiaudioDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiaudioConfigurationsUiaudioDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiaudioConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiaudioDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UiaudioConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiaudioDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiaudioConfiguration"
        TargetTable =
         { Name = TableName "UiaudioConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiaudioConfigurationsId"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiaudioConfigurationsUiaudioDetail"
                          Name = "UiaudioConfigurationsUiaudioDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiaudioConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiaudioDetail"
        TargetTable =
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
        Destination = EntityName "UiaudioDetail"
        IsNullable = false
        KeyType = Guid }] }-UiaudioConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiaudioConfigurations
                                    .Where(x => x.UiaudioConfiguration != null && ids.Contains((Guid)x.UiaudioConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiaudioConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiaudioConfiguration);
                });
            
			
                Field<UiaudioDetailGraphType, UiaudioDetail>("UiaudioDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiaudioDetailGraphType>(
                            "{ Name = EntityName "UiaudioConfigurationsUiaudioDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UiaudioConfigurationsUiaudioDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiaudioConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UiaudioDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UiaudioConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiaudioDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UiaudioConfiguration"
        TargetTable =
         { Name = TableName "UiaudioConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiaudioConfigurationsId"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UiaudioConfigurationsUiaudioDetail"
                          Name = "UiaudioConfigurationsUiaudioDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UiaudioConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UiaudioDetail"
        TargetTable =
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
        Destination = EntityName "UiaudioDetail"
        IsNullable = false
        KeyType = Guid }] }-UiaudioDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UiaudioDetails
                                    .Where(x => x.UiaudioDetail != null && ids.Contains((Guid)x.UiaudioDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UiaudioDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UiaudioDetail);
                });
            
        }
    }
}
            
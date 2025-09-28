
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
    public partial class DefaultPinConfigurationsDefaultPinDetailGraphType : ObjectGraphType<DefaultPinConfigurationsDefaultPinDetail>
    {
        public DefaultPinConfigurationsDefaultPinDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DefaultPinConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DefaultPinDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<DefaultPinConfigurationGraphType, DefaultPinConfiguration>("DefaultPinConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DefaultPinConfigurationGraphType>(
                            "{ Name = EntityName "DefaultPinConfigurationsDefaultPinDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "DefaultPinConfigurationsDefaultPinDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DefaultPinConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "DefaultPinDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "DefaultPinConfiguration"
                      Name = "DefaultPinConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "DefaultPinDetail"
                      Name = "DefaultPinDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "DefaultPinConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "DefaultPinDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DefaultPinConfiguration"
        TargetTable =
         { Name = TableName "DefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
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
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DefaultPinConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DefaultPinDetail"
        TargetTable =
         { Name = TableName "DefaultPinDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinDetailId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "VirtualPinNumber"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "High"
                                                           IsNullable = false };
             ForeignKey { Type = Short
                          Name = "GpioPinTypeId"
                          IsNullable = false };
             Navigation
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "DefaultGpioPinType"
                          Name = "GpioPinType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "DefaultPinDetail"
        IsNullable = false
        KeyType = Guid }] }-DefaultPinConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.DefaultPinConfigurations
                                    .Where(x => x.DefaultPinConfiguration != null && ids.Contains((Guid)x.DefaultPinConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DefaultPinConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.DefaultPinConfiguration);
                });
            
			
                Field<DefaultPinDetailGraphType, DefaultPinDetail>("DefaultPinDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DefaultPinDetailGraphType>(
                            "{ Name = EntityName "DefaultPinConfigurationsDefaultPinDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "DefaultPinConfigurationsDefaultPinDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "DefaultPinConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "DefaultPinDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "DefaultPinConfiguration"
                      Name = "DefaultPinConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "DefaultPinDetail"
                      Name = "DefaultPinDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "DefaultPinConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "DefaultPinDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DefaultPinConfiguration"
        TargetTable =
         { Name = TableName "DefaultPinConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
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
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DefaultPinConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "DefaultPinDetail"
        TargetTable =
         { Name = TableName "DefaultPinDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DefaultPinDetailId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "VirtualPinNumber"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "High"
                                                           IsNullable = false };
             ForeignKey { Type = Short
                          Name = "GpioPinTypeId"
                          IsNullable = false };
             Navigation
               { Type = TableName "DefaultPinConfigurationsDefaultPinDetail"
                 Name = "DefaultPinConfigurationsDefaultPinDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "DefaultGpioPinType"
                          Name = "GpioPinType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "DefaultPinDetail"
        IsNullable = false
        KeyType = Guid }] }-DefaultPinDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.DefaultPinDetails
                                    .Where(x => x.DefaultPinDetail != null && ids.Contains((Guid)x.DefaultPinDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DefaultPinDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.DefaultPinDetail);
                });
            
        }
    }
}
            
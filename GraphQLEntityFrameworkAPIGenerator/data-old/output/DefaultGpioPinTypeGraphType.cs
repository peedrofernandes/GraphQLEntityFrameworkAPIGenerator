
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
    public partial class DefaultGpioPinTypeGraphType : ObjectGraphType<DefaultGpioPinType>
    {
        public DefaultGpioPinTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.IsOutput, type: typeof(BoolGraphType), nullable: False);
            
                Field<DefaultPinDetailGraphType, DefaultPinDetail>("DefaultPinDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<DefaultPinDetailGraphType>>(
                            "{ Name = EntityName "DefaultGpioPinType"
  CorrespondingTable =
   Regular
     { Name = TableName "DefaultGpioPinType"
       Properties =
        [PrimaryKey { Type = Short
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsOutput"
                     IsNullable = false };
         Navigation { Type = TableName "DefaultPinDetail"
                      Name = "DefaultPinDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidefaultPinDetail"
                      Name = "UidefaultPinDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "Id"
      Type = Id Short
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "IsOutput"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidefaultPinDetail"
        TargetTable =
         { Name = TableName "UidefaultPinDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidefaultPinDetailId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "VirtualPinNumber"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "High"
                                                           IsNullable = false };
             ForeignKey { Type = Short
                          Name = "GpioPinTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "DefaultGpioPinType"
                          Name = "GpioPinType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UidefaultPinConfigurationsUidefaultPinDetail"
                 Name = "UidefaultPinConfigurationsUidefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UidefaultPinDetail"
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
                            });

                        return loader.LoadAsync(context.Source.DefaultPinDetails);
                    });
            
			
                Field<UidefaultPinDetailGraphType, UidefaultPinDetail>("UidefaultPinDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UidefaultPinDetailGraphType>>(
                            "{ Name = EntityName "DefaultGpioPinType"
  CorrespondingTable =
   Regular
     { Name = TableName "DefaultGpioPinType"
       Properties =
        [PrimaryKey { Type = Short
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "Description"
                                                        IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsOutput"
                     IsNullable = false };
         Navigation { Type = TableName "DefaultPinDetail"
                      Name = "DefaultPinDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "UidefaultPinDetail"
                      Name = "UidefaultPinDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "Id"
      Type = Id Short
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "IsOutput"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UidefaultPinDetail"
        TargetTable =
         { Name = TableName "UidefaultPinDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UidefaultPinDetailId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "VirtualPinNumber"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "High"
                                                           IsNullable = false };
             ForeignKey { Type = Short
                          Name = "GpioPinTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "DefaultGpioPinType"
                          Name = "GpioPinType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "UidefaultPinConfigurationsUidefaultPinDetail"
                 Name = "UidefaultPinConfigurationsUidefaultPinDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UidefaultPinDetail"
        KeyType = Guid }] }-UidefaultPinDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UidefaultPinDetails
                                    .Where(x => x.UidefaultPinDetail != null && ids.Contains((Guid)x.UidefaultPinDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UidefaultPinDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UidefaultPinDetails);
                    });
            
        }
    }
}
            
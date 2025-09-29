
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
    public partial class LoadConfigurationsLoadDetailGraphType : ObjectGraphType<LoadConfigurationsLoadDetail>
    {
        public LoadConfigurationsLoadDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LoadConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.LoadDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<LoadConfigurationGraphType, LoadConfiguration>("LoadConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, LoadConfigurationGraphType>(
                            "{ Name = EntityName "LoadConfigurationsLoadDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "LoadConfigurationsLoadDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LoadConfigurationId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "LoadDetailId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false };
         Navigation { Type = TableName "LoadConfiguration"
                      Name = "LoadConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "LoadDetail"
                      Name = "LoadDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "LoadConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "LoadDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "LoadConfiguration"
        TargetTable =
         { Name = TableName "LoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
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
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LoadDetail"
        TargetTable =
         { Name = TableName "LoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Pin1"
                                                            IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "OnLevel1"
                                                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel2"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "OnLevel3"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel4"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PilotParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "FeedbackParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LoadParametersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "Uidriven"
                                                           IsNullable = false };
             Navigation { Type = TableName "FeedbackParameter"
                          Name = "FeedbackParameters"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadDetail"
        IsNullable = false
        KeyType = Guid }] }-LoadConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.LoadConfigurations
                                    .Where(x => x.LoadConfiguration != null && ids.Contains((Guid)x.LoadConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.LoadConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.LoadConfiguration);
                });
            
			
                Field<LoadDetailGraphType, LoadDetail>("LoadDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, LoadDetailGraphType>(
                            "{ Name = EntityName "LoadConfigurationsLoadDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "LoadConfigurationsLoadDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LoadConfigurationId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "LoadDetailId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false };
         Navigation { Type = TableName "LoadConfiguration"
                      Name = "LoadConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "LoadDetail"
                      Name = "LoadDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "LoadConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "LoadDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "LoadConfiguration"
        TargetTable =
         { Name = TableName "LoadConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadConfigurationId"
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
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LoadDetail"
        TargetTable =
         { Name = TableName "LoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LoadDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Pin1"
                                                            IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true }; Primitive { Type = Bool
                                                          Name = "OnLevel1"
                                                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel2"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "OnLevel3"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "OnLevel4"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PilotParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "FeedbackParametersId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LoadParametersId"
                          IsNullable = true }; Primitive { Type = Bool
                                                           Name = "Uidriven"
                                                           IsNullable = false };
             Navigation { Type = TableName "FeedbackParameter"
                          Name = "FeedbackParameters"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Load"
                          Name = "Load"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadConfigurationsLoadDetail"
                          Name = "LoadConfigurationsLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LoadDetail"
        IsNullable = false
        KeyType = Guid }] }-LoadDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.LoadDetails
                                    .Where(x => x.LoadDetail != null && ids.Contains((Guid)x.LoadDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.LoadDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.LoadDetail);
                });
            
        }
    }
}
            
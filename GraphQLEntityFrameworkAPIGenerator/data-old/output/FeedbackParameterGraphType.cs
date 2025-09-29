
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
    public partial class FeedbackParameterGraphType : ObjectGraphType<FeedbackParameter>
    {
        public FeedbackParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FeedbackParametersId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.FeedbacksNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StatesNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ItemsNumber, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypeId1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypePos1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypeId2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypePos2, type: typeof(ByteGraphType), nullable: False);
            
                Field<LoadDetailGraphType, LoadDetail>("LoadDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LoadDetailGraphType>>(
                            "{ Name = EntityName "FeedbackParameter"
  CorrespondingTable =
   Regular
     { Name = TableName "FeedbackParameter"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "FeedbackParametersId"
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
                                                      Name = "FeedbacksNumber"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "StatesNumber"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ItemsNumber"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ReadTypeId1"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ReadTypePos1"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ReadTypeId2"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "ReadTypePos2"
                                                       IsNullable = false };
         Navigation { Type = TableName "LoadDetail"
                      Name = "LoadDetails"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "FeedbackParametersId"
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
    { Name = "FeedbacksNumber"
      Type = Primitive Byte
      IsNullable = false }; { Name = "StatesNumber"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ItemsNumber"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ReadTypeId1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ReadTypePos1"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ReadTypeId2"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ReadTypePos2"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
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
                            });

                        return loader.LoadAsync(context.Source.LoadDetails);
                    });
            
        }
    }
}
            
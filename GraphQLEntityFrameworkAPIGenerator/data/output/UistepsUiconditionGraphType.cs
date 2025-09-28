
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
    public partial class UistepsUiconditionGraphType : ObjectGraphType<UistepsUicondition>
    {
        public UistepsUiconditionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UistepId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UiconditionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiconditionGraphType, Uicondition>("Uiconditions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiconditionGraphType>(
                            "{ Name = EntityName "UistepsUicondition"
  CorrespondingTable =
   Regular
     { Name = TableName "UistepsUicondition"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UistepId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "UiconditionId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false };
         Navigation { Type = TableName "Uicondition"
                      Name = "Uicondition"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "Uistep"
                      Name = "Uistep"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UistepId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiconditionId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Uicondition"
        TargetTable =
         { Name = TableName "Uicondition"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiconditionId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Givalue"
                                                           IsNullable = false };
             Navigation { Type = TableName "UisequenceConfigurationsUisequence"
                          Name = "UisequenceConfigurationsUisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistepsUicondition"
                          Name = "UistepsUiconditions"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uicondition"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Uistep"
        TargetTable =
         { Name = TableName "Uistep"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UistepId"
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
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Timer"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Timeout"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "DisableFunctionLayer"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FeedbackCode"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UisequencesUistep"
                          Name = "UisequencesUisteps"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistepsUicondition"
                          Name = "UistepsUiconditions"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uistep"
        IsNullable = false
        KeyType = Guid }] }-Uicondition-loader",
                            async ids => 
                            {
                                var data = await dbContext.Uiconditions
                                    .Where(x => x.Uicondition != null && ids.Contains((Guid)x.Uicondition))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Uicondition!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Uicondition);
                });
            
			
                Field<UistepGraphType, Uistep>("Uisteps")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UistepGraphType>(
                            "{ Name = EntityName "UistepsUicondition"
  CorrespondingTable =
   Regular
     { Name = TableName "UistepsUicondition"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UistepId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "UiconditionId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false };
         Navigation { Type = TableName "Uicondition"
                      Name = "Uicondition"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "Uistep"
                      Name = "Uistep"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UistepId"
      Type = Id Guid
      IsNullable = false }; { Name = "UiconditionId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Uicondition"
        TargetTable =
         { Name = TableName "Uicondition"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiconditionId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Givalue"
                                                           IsNullable = false };
             Navigation { Type = TableName "UisequenceConfigurationsUisequence"
                          Name = "UisequenceConfigurationsUisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistepsUicondition"
                          Name = "UistepsUiconditions"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uicondition"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Uistep"
        TargetTable =
         { Name = TableName "Uistep"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UistepId"
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
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Timer"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "Timeout"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "DisableFunctionLayer"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "FeedbackCode"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UisequencesUistep"
                          Name = "UisequencesUisteps"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistepsUicondition"
                          Name = "UistepsUiconditions"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uistep"
        IsNullable = false
        KeyType = Guid }] }-Uistep-loader",
                            async ids => 
                            {
                                var data = await dbContext.Uisteps
                                    .Where(x => x.Uistep != null && ids.Contains((Guid)x.Uistep))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Uistep!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Uistep);
                });
            
        }
    }
}
            
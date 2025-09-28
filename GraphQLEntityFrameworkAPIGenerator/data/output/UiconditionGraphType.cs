
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
    public partial class UiconditionGraphType : ObjectGraphType<Uicondition>
    {
        public UiconditionGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiconditionId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.GireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Givalue, type: typeof(ByteGraphType), nullable: False);
            
                Field<UisequenceConfigurationsUisequenceGraphType, UisequenceConfigurationsUisequence>("UisequenceConfigurationsUisequences")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UisequenceConfigurationsUisequenceGraphType>>(
                            "{ Name = EntityName "Uicondition"
  CorrespondingTable =
   Regular
     { Name = TableName "Uicondition"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiconditionId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
  Fields =
   [{ Name = "UiconditionId"
      Type = Id Guid
      IsNullable = false }; { Name = "GireadTypePosition"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Givalue"
                                                      Type = Primitive Byte
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UisequenceConfigurationsUisequence"
        TargetTable =
         { Name = TableName "UisequenceConfigurationsUisequence"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisequenceConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UisequenceId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UiconditionId"
                          IsNullable = true };
             Navigation { Type = TableName "Uicondition"
                          Name = "Uicondition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uisequence"
                          Name = "Uisequence"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "UisequenceConfiguration"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UisequenceConfigurationsUisequence"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UistepsUicondition"
        TargetTable =
         { Name = TableName "UistepsUicondition"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UistepId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
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
        Destination = EntityName "UistepsUicondition"
        KeyType = Guid }] }-UisequenceConfigurationsUisequence-loader",
                            async ids => 
                            {
                                var data = await dbContext.UisequenceConfigurationsUisequences
                                    .Where(x => x.UisequenceConfigurationsUisequence != null && ids.Contains((Guid)x.UisequenceConfigurationsUisequence))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UisequenceConfigurationsUisequence!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UisequenceConfigurationsUisequences);
                    });
            
			
                Field<UistepsUiconditionGraphType, UistepsUicondition>("UistepsUiconditions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UistepsUiconditionGraphType>>(
                            "{ Name = EntityName "Uicondition"
  CorrespondingTable =
   Regular
     { Name = TableName "Uicondition"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UiconditionId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
  Fields =
   [{ Name = "UiconditionId"
      Type = Id Guid
      IsNullable = false }; { Name = "GireadTypePosition"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Givalue"
                                                      Type = Primitive Byte
                                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UisequenceConfigurationsUisequence"
        TargetTable =
         { Name = TableName "UisequenceConfigurationsUisequence"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisequenceConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UisequenceId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UiconditionId"
                          IsNullable = true };
             Navigation { Type = TableName "Uicondition"
                          Name = "Uicondition"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uisequence"
                          Name = "Uisequence"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UisequenceConfiguration"
                          Name = "UisequenceConfiguration"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UisequenceConfigurationsUisequence"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UistepsUicondition"
        TargetTable =
         { Name = TableName "UistepsUicondition"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UistepId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
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
        Destination = EntityName "UistepsUicondition"
        KeyType = Guid }] }-UistepsUicondition-loader",
                            async ids => 
                            {
                                var data = await dbContext.UistepsUiconditions
                                    .Where(x => x.UistepsUicondition != null && ids.Contains((Guid)x.UistepsUicondition))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UistepsUicondition!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UistepsUiconditions);
                    });
            
        }
    }
}
            
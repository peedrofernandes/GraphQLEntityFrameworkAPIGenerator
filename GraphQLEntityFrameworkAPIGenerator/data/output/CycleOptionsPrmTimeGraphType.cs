
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
    public partial class CycleOptionsPrmTimeGraphType : ObjectGraphType<CycleOptionsPrmTime>
    {
        public CycleOptionsPrmTimeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.TimeOptionsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfSelections, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.UserCookTimeSelectionBehavior, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UserCookTimeDisplayBehavior, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UserCookTime1, type: typeof(IdGraphType), nullable: False);
			Field(t => t.UserCookTime2, type: typeof(IdGraphType), nullable: False);
			Field(t => t.UserCookTime3, type: typeof(IdGraphType), nullable: False);
			Field(t => t.UserCookTime4, type: typeof(IdGraphType), nullable: True);
			Field(t => t.UserCookTime5, type: typeof(IdGraphType), nullable: True);
			Field(t => t.UserCookTime6, type: typeof(IdGraphType), nullable: True);
			Field(t => t.Step, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Units, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UserCookTimeDefaultSelection, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Name1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Name2, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Name3, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Name4, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Name5, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Name6, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NameDefault, type: typeof(ByteGraphType), nullable: False);
            
                Field<CycleTimeOptionsDisplayBehaviorLabelGraphType, CycleTimeOptionsDisplayBehaviorLabel>("CycleTimeOptionsDisplayBehaviorLabels")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleTimeOptionsDisplayBehaviorLabelGraphType>(
                            "{ Name = EntityName "CycleOptionsPrmTime"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleOptionsPrmTime"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "TimeOptionsId"
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
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "NumberOfSelections"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "UserCookTimeSelectionBehavior"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "UserCookTimeDisplayBehavior"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "UserCookTime1"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "UserCookTime2"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "UserCookTime3"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "UserCookTime4"
                     IsNullable = true }; Primitive { Type = Int
                                                      Name = "UserCookTime5"
                                                      IsNullable = true };
         Primitive { Type = Int
                     Name = "UserCookTime6"
                     IsNullable = true }; Primitive { Type = Int
                                                      Name = "Step"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "Units"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "UserCookTimeDefaultSelection"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Name1"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Name2"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Name3"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Name4"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Name5"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Name6"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "NameDefault"
                                                       IsNullable = false };
         Navigation { Type = TableName "CycleTimeOptionsDisplayBehaviorLabel"
                      Name = "UserCookTimeDisplayBehaviorNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleTimeOptionsSelectionBehaviorLabel"
                      Name = "UserCookTimeSelectionBehaviorNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "TimeOptionsId"
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
    { Name = "NumberOfSelections"
      Type = Primitive Byte
      IsNullable = true }; { Name = "UserCookTimeSelectionBehavior"
                             Type = Primitive Byte
                             IsNullable = false };
    { Name = "UserCookTimeDisplayBehavior"
      Type = Primitive Byte
      IsNullable = false }; { Name = "UserCookTime1"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "UserCookTime2"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "UserCookTime3"
      Type = Primitive Int
      IsNullable = false }; { Name = "UserCookTime4"
                              Type = Primitive Int
                              IsNullable = true }; { Name = "UserCookTime5"
                                                     Type = Primitive Int
                                                     IsNullable = true };
    { Name = "UserCookTime6"
      Type = Primitive Int
      IsNullable = true }; { Name = "Step"
                             Type = Primitive Int
                             IsNullable = false }; { Name = "Units"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "UserCookTimeDefaultSelection"
      Type = Primitive Int
      IsNullable = false }; { Name = "Name1"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Name2"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Name3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Name4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Name5"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Name6"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NameDefault"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleTimeOptionsDisplayBehaviorLabel"
        TargetTable =
         { Name = TableName "CycleTimeOptionsDisplayBehaviorLabel"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Behavior"
                                                            IsNullable = false };
             Navigation { Type = TableName "CycleOptionsPrmTime"
                          Name = "CycleOptionsPrmTimes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleTimeOptionsDisplayBehaviorLabel"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "CycleTimeOptionsSelectionBehaviorLabel"
        TargetTable =
         { Name = TableName "CycleTimeOptionsSelectionBehaviorLabel"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Behavior"
                                                            IsNullable = false };
             Navigation { Type = TableName "CycleOptionsPrmTime"
                          Name = "CycleOptionsPrmTimes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleTimeOptionsSelectionBehaviorLabel"
        IsNullable = false
        KeyType = Byte }] }-CycleTimeOptionsDisplayBehaviorLabel-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleTimeOptionsDisplayBehaviorLabels
                                    .Where(x => x.CycleTimeOptionsDisplayBehaviorLabel != null && ids.Contains((byte)x.CycleTimeOptionsDisplayBehaviorLabel))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.CycleTimeOptionsDisplayBehaviorLabel!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleTimeOptionsDisplayBehaviorLabel);
                });
            
			
                Field<CycleTimeOptionsSelectionBehaviorLabelGraphType, CycleTimeOptionsSelectionBehaviorLabel>("CycleTimeOptionsSelectionBehaviorLabels")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CycleTimeOptionsSelectionBehaviorLabelGraphType>(
                            "{ Name = EntityName "CycleOptionsPrmTime"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleOptionsPrmTime"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "TimeOptionsId"
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
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "NumberOfSelections"
                     IsNullable = true };
         Primitive { Type = Byte
                     Name = "UserCookTimeSelectionBehavior"
                     IsNullable = false };
         Primitive { Type = Byte
                     Name = "UserCookTimeDisplayBehavior"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "UserCookTime1"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "UserCookTime2"
                     IsNullable = false }; Primitive { Type = Int
                                                       Name = "UserCookTime3"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "UserCookTime4"
                     IsNullable = true }; Primitive { Type = Int
                                                      Name = "UserCookTime5"
                                                      IsNullable = true };
         Primitive { Type = Int
                     Name = "UserCookTime6"
                     IsNullable = true }; Primitive { Type = Int
                                                      Name = "Step"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "Units"
                     IsNullable = false };
         Primitive { Type = Int
                     Name = "UserCookTimeDefaultSelection"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Name1"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Name2"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Name3"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Name4"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Name5"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Name6"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "NameDefault"
                                                       IsNullable = false };
         Navigation { Type = TableName "CycleTimeOptionsDisplayBehaviorLabel"
                      Name = "UserCookTimeDisplayBehaviorNavigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "CycleTimeOptionsSelectionBehaviorLabel"
                      Name = "UserCookTimeSelectionBehaviorNavigation"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "TimeOptionsId"
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
    { Name = "NumberOfSelections"
      Type = Primitive Byte
      IsNullable = true }; { Name = "UserCookTimeSelectionBehavior"
                             Type = Primitive Byte
                             IsNullable = false };
    { Name = "UserCookTimeDisplayBehavior"
      Type = Primitive Byte
      IsNullable = false }; { Name = "UserCookTime1"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "UserCookTime2"
                                                      Type = Primitive Int
                                                      IsNullable = false };
    { Name = "UserCookTime3"
      Type = Primitive Int
      IsNullable = false }; { Name = "UserCookTime4"
                              Type = Primitive Int
                              IsNullable = true }; { Name = "UserCookTime5"
                                                     Type = Primitive Int
                                                     IsNullable = true };
    { Name = "UserCookTime6"
      Type = Primitive Int
      IsNullable = true }; { Name = "Step"
                             Type = Primitive Int
                             IsNullable = false }; { Name = "Units"
                                                     Type = Primitive Byte
                                                     IsNullable = false };
    { Name = "UserCookTimeDefaultSelection"
      Type = Primitive Int
      IsNullable = false }; { Name = "Name1"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Name2"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Name3"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Name4"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Name5"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Name6"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NameDefault"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "CycleTimeOptionsDisplayBehaviorLabel"
        TargetTable =
         { Name = TableName "CycleTimeOptionsDisplayBehaviorLabel"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Behavior"
                                                            IsNullable = false };
             Navigation { Type = TableName "CycleOptionsPrmTime"
                          Name = "CycleOptionsPrmTimes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleTimeOptionsDisplayBehaviorLabel"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "CycleTimeOptionsSelectionBehaviorLabel"
        TargetTable =
         { Name = TableName "CycleTimeOptionsSelectionBehaviorLabel"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Behavior"
                                                            IsNullable = false };
             Navigation { Type = TableName "CycleOptionsPrmTime"
                          Name = "CycleOptionsPrmTimes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleTimeOptionsSelectionBehaviorLabel"
        IsNullable = false
        KeyType = Byte }] }-CycleTimeOptionsSelectionBehaviorLabel-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleTimeOptionsSelectionBehaviorLabels
                                    .Where(x => x.CycleTimeOptionsSelectionBehaviorLabel != null && ids.Contains((byte)x.CycleTimeOptionsSelectionBehaviorLabel))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.CycleTimeOptionsSelectionBehaviorLabel!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CycleTimeOptionsSelectionBehaviorLabel);
                });
            
        }
    }
}
            
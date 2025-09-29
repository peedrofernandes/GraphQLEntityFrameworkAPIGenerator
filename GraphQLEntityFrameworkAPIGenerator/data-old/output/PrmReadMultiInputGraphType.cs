
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
    public partial class PrmReadMultiInputGraphType : ObjectGraphType<PrmReadMultiInput>
    {
        public PrmReadMultiInputGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ReadTypeId0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadParametersId0, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ReadTypeId1, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadParametersId1, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ReadTypeId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ReadParametersId2, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ReadTypeId3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.ReadParametersId3, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.NumOfPins, type: typeof(ByteGraphType), nullable: False);
            
                Field<ReadTypeGraphType, ReadType>("ReadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ReadTypeGraphType>(
                            "{ Name = EntityName "PrmReadMultiInput"
  CorrespondingTable =
   Regular
     { Name = TableName "PrmReadMultiInput"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "ReadTypeId0"
                                                        IsNullable = false };
         Primitive { Type = Guid
                     Name = "ReadParametersId0"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "ReadTypeId1"
                                                      IsNullable = false };
         Primitive { Type = Guid
                     Name = "ReadParametersId1"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "ReadTypeId2"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ReadParametersId2"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "ReadTypeId3"
                                                      IsNullable = true };
         Primitive { Type = Guid
                     Name = "ReadParametersId3"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "NumOfPins"
                                                      IsNullable = false };
         Navigation { Type = TableName "ReadType"
                      Name = "ReadTypeId0Navigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "ReadType"
                      Name = "ReadTypeId1Navigation"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "ReadType"
                      Name = "ReadTypeId2Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "ReadType"
                      Name = "ReadTypeId3Navigation"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "ReadTypeId0"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "ReadParametersId0"
                                                      Type = Primitive Guid
                                                      IsNullable = true };
    { Name = "ReadTypeId1"
      Type = Primitive Byte
      IsNullable = false }; { Name = "ReadParametersId1"
                              Type = Primitive Guid
                              IsNullable = true }; { Name = "ReadTypeId2"
                                                     Type = Primitive Byte
                                                     IsNullable = true };
    { Name = "ReadParametersId2"
      Type = Primitive Guid
      IsNullable = true }; { Name = "ReadTypeId3"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "ReadParametersId3"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "NumOfPins"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "ReadTypeId0Navigation";
          RelationName "ReadTypeId1Navigation";
          RelationName "ReadTypeId2Navigation";
          RelationName "ReadTypeId3Navigation"]
        TargetTable =
         { Name = TableName "ReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "ReadTypeDsc"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "ReadTypeMax"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "NumPins"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "NeedParams"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Automatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Multiplexed"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Inverted"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Partialized"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Acline"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Vreference"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Compensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Delta"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Rotation"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "PullUp"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Feedback"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "SecondFeedback"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "GenericInputDetail"
                          Name = "GenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InputTypesReadType"
                          Name = "InputTypesReadTypes"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputDetail"
                          Name = "LowLevelInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MultiInputReadType"
                          Name = "MultiInputReadType"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "Uiinputs"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "UiinputsNavigation"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ReadType"
        IsNullable = false
        KeyType = Byte }] }-ReadType-loader",
                            async ids => 
                            {
                                Expression<Func<ReadType, bool>> expr = x => !ids.Any()
                                    \|\| (x.ReadTypeId0Navigation != null && ids.Contains((byte)x.ReadTypeId0Navigation))
\|\| (x.ReadTypeId1Navigation != null && ids.Contains((byte)x.ReadTypeId1Navigation))
\|\| (x.ReadTypeId2Navigation != null && ids.Contains((byte)x.ReadTypeId2Navigation))
\|\| (x.ReadTypeId3Navigation != null && ids.Contains((byte)x.ReadTypeId3Navigation));

                                var data = await dbContext.ReadTypes
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<byte?>()
                                    {
                                        x.ReadTypeId0Navigation,
x.ReadTypeId1Navigation,
x.ReadTypeId2Navigation,
x.ReadTypeId3Navigation
                                    }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.ReadTypes);
                    });
            
        }
    }
}
            
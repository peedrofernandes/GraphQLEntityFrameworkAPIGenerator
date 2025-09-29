
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
    public partial class CrossLoadDetailGraphType : ObjectGraphType<CrossLoadDetail>
    {
        public CrossLoadDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CrossLoadDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.OnDelayTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.OffDelayTime, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.CouplesNum, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LoadOnDisconnected, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.LoadOffDisconnected, type: typeof(ShortGraphType), nullable: False);
            
                Field<CrossLoadConfigurationsCrossLoadDetailGraphType, CrossLoadConfigurationsCrossLoadDetail>("CrossLoadConfigurationsCrossLoadDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CrossLoadConfigurationsCrossLoadDetailGraphType>>(
                            "{ Name = EntityName "CrossLoadDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "CrossLoadDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CrossLoadDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "LoadId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "CrossLoadTypeId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "OnDelayTime"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "OffDelayTime"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "CouplesNum"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "LoadOnDisconnected"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "LoadOffDisconnected"
                     IsNullable = false };
         Navigation { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                      Name = "CrossLoadConfigurationsCrossLoadDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CrossLoadType"
                      Name = "CrossLoadType"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "Load"
                      Name = "Load"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CrossLoadDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "OnDelayTime"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "OffDelayTime"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "CouplesNum"
      Type = Primitive Byte
      IsNullable = false }; { Name = "LoadOnDisconnected"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "LoadOffDisconnected"
      Type = Primitive Short
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CrossLoadConfigurationsCrossLoadDetail"
        TargetTable =
         { Name = TableName "CrossLoadConfigurationsCrossLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CrossLoadDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CrossLoadDetail"
                          Name = "CrossLoadDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfigurationsCrossLoadDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadType"
        TargetTable =
         { Name = TableName "CrossLoadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "CrossLoadTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "CrossLoadTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "CrossLoadDetail"
                          Name = "CrossLoadDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CrossLoadType"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "Load"
        TargetTable =
         { Name = TableName "Load"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LoadDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadTypeId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "LoadsControl"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "CrossLoadDetail"
                          Name = "CrossLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadType"
                          Name = "LoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId9Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadGroup"
                          Name = "LoadGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Load"
        IsNullable = false
        KeyType = Byte }] }-CrossLoadConfigurationsCrossLoadDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.CrossLoadConfigurationsCrossLoadDetails
                                    .Where(x => x.CrossLoadConfigurationsCrossLoadDetail != null && ids.Contains((Guid)x.CrossLoadConfigurationsCrossLoadDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CrossLoadConfigurationsCrossLoadDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CrossLoadConfigurationsCrossLoadDetails);
                    });
            
			
                Field<CrossLoadTypeGraphType, CrossLoadType>("CrossLoadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, CrossLoadTypeGraphType>(
                            "{ Name = EntityName "CrossLoadDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "CrossLoadDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CrossLoadDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "LoadId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "CrossLoadTypeId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "OnDelayTime"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "OffDelayTime"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "CouplesNum"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "LoadOnDisconnected"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "LoadOffDisconnected"
                     IsNullable = false };
         Navigation { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                      Name = "CrossLoadConfigurationsCrossLoadDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CrossLoadType"
                      Name = "CrossLoadType"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "Load"
                      Name = "Load"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CrossLoadDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "OnDelayTime"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "OffDelayTime"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "CouplesNum"
      Type = Primitive Byte
      IsNullable = false }; { Name = "LoadOnDisconnected"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "LoadOffDisconnected"
      Type = Primitive Short
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CrossLoadConfigurationsCrossLoadDetail"
        TargetTable =
         { Name = TableName "CrossLoadConfigurationsCrossLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CrossLoadDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CrossLoadDetail"
                          Name = "CrossLoadDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfigurationsCrossLoadDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadType"
        TargetTable =
         { Name = TableName "CrossLoadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "CrossLoadTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "CrossLoadTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "CrossLoadDetail"
                          Name = "CrossLoadDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CrossLoadType"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "Load"
        TargetTable =
         { Name = TableName "Load"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LoadDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadTypeId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "LoadsControl"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "CrossLoadDetail"
                          Name = "CrossLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadType"
                          Name = "LoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId9Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadGroup"
                          Name = "LoadGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Load"
        IsNullable = false
        KeyType = Byte }] }-CrossLoadType-loader",
                            async ids => 
                            {
                                var data = await dbContext.CrossLoadTypes
                                    .Where(x => x.CrossLoadType != null && ids.Contains((byte)x.CrossLoadType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.CrossLoadType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.CrossLoadType);
                });
            
			
                Field<LoadGraphType, Load>("Loads")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, LoadGraphType>(
                            "{ Name = EntityName "CrossLoadDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "CrossLoadDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CrossLoadDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "LoadId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "CrossLoadTypeId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "OnDelayTime"
                                                        IsNullable = false };
         Primitive { Type = Byte
                     Name = "OffDelayTime"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "CouplesNum"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "LoadOnDisconnected"
                     IsNullable = false };
         Primitive { Type = Short
                     Name = "LoadOffDisconnected"
                     IsNullable = false };
         Navigation { Type = TableName "CrossLoadConfigurationsCrossLoadDetail"
                      Name = "CrossLoadConfigurationsCrossLoadDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "CrossLoadType"
                      Name = "CrossLoadType"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "Load"
                      Name = "Load"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "CrossLoadDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "OnDelayTime"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "OffDelayTime"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "CouplesNum"
      Type = Primitive Byte
      IsNullable = false }; { Name = "LoadOnDisconnected"
                              Type = Primitive Short
                              IsNullable = false };
    { Name = "LoadOffDisconnected"
      Type = Primitive Short
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "CrossLoadConfigurationsCrossLoadDetail"
        TargetTable =
         { Name = TableName "CrossLoadConfigurationsCrossLoadDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "CrossLoadDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "CrossLoadDetail"
                          Name = "CrossLoadDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "CrossLoadConfigurationsCrossLoadDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "CrossLoadType"
        TargetTable =
         { Name = TableName "CrossLoadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "CrossLoadTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "CrossLoadTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "CrossLoadDetail"
                          Name = "CrossLoadDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CrossLoadType"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "Load"
        TargetTable =
         { Name = TableName "Load"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "LoadId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "LoadDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LoadTypeId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "LoadsControl"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "CrossLoadDetail"
                          Name = "CrossLoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadDetail"
                          Name = "LoadDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadType"
                          Name = "LoadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId4Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId5Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId6Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId7Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId8Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadsControlPilotParameter"
                          Name = "LoadsControlPilotParameterLoadId9Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LoadGroup"
                          Name = "LoadGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Load"
        IsNullable = false
        KeyType = Byte }] }-Load-loader",
                            async ids => 
                            {
                                var data = await dbContext.Loads
                                    .Where(x => x.Load != null && ids.Contains((byte)x.Load))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.Load!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Load);
                });
            
        }
    }
}
            
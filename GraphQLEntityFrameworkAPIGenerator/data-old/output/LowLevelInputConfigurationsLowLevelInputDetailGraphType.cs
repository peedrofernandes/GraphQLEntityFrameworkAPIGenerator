
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
    public partial class LowLevelInputConfigurationsLowLevelInputDetailGraphType : ObjectGraphType<LowLevelInputConfigurationsLowLevelInputDetail>
    {
        public LowLevelInputConfigurationsLowLevelInputDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LowLevelInputConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.LowLevelInputDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<LowLevelInputConfigurationGraphType, LowLevelInputConfiguration>("LowLevelInputConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, LowLevelInputConfigurationGraphType>(
                            "{ Name = EntityName "LowLevelInputConfigurationsLowLevelInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "LowLevelInputConfigurationsLowLevelInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LowLevelInputConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "LowLevelInputDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "LowLevelInputConfiguration"
                      Name = "LowLevelInputConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "LowLevelInputDetail"
                      Name = "LowLevelInputDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "LowLevelInputConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "LowLevelInputDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "LowLevelInputConfiguration"
        TargetTable =
         { Name = TableName "LowLevelInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
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
                                                           Name = "Board"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LowLevelInputConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LowLevelInputDetail"
        TargetTable =
         { Name = TableName "LowLevelInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Delta"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ChipSelect"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAutomatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsMultiplexed"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAcline"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsVreference"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCompensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsInverted"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsPartialized"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Rotation"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "PullUp"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
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
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ReadParametersId"
                          IsNullable = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "ReadType"
                                                     Name = "ReadType"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "LowLevelInputDetail"
        IsNullable = false
        KeyType = Guid }] }-LowLevelInputConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.LowLevelInputConfigurations
                                    .Where(x => x.LowLevelInputConfiguration != null && ids.Contains((Guid)x.LowLevelInputConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.LowLevelInputConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.LowLevelInputConfiguration);
                });
            
			
                Field<LowLevelInputDetailGraphType, LowLevelInputDetail>("LowLevelInputDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, LowLevelInputDetailGraphType>(
                            "{ Name = EntityName "LowLevelInputConfigurationsLowLevelInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "LowLevelInputConfigurationsLowLevelInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LowLevelInputConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "LowLevelInputDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "LowLevelInputConfiguration"
                      Name = "LowLevelInputConfiguration"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "LowLevelInputDetail"
                      Name = "LowLevelInputDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "LowLevelInputConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "LowLevelInputDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "LowLevelInputConfiguration"
        TargetTable =
         { Name = TableName "LowLevelInputConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
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
                                                           Name = "Board"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "LowLevelInputConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "LowLevelInputDetail"
        TargetTable =
         { Name = TableName "LowLevelInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Delta"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ChipSelect"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAutomatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsMultiplexed"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAcline"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsVreference"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCompensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsInverted"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsPartialized"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Rotation"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "PullUp"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
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
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ReadParametersId"
                          IsNullable = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "ReadType"
                                                     Name = "ReadType"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "LowLevelInputDetail"
        IsNullable = false
        KeyType = Guid }] }-LowLevelInputDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.LowLevelInputDetails
                                    .Where(x => x.LowLevelInputDetail != null && ids.Contains((Guid)x.LowLevelInputDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.LowLevelInputDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.LowLevelInputDetail);
                });
            
        }
    }
}
            
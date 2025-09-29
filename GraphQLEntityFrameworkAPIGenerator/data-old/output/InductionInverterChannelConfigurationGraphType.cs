
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
    public partial class InductionInverterChannelConfigurationGraphType : ObjectGraphType<InductionInverterChannelConfiguration>
    {
        public InductionInverterChannelConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InverterChannelId, type: typeof(GuidGraphType), nullable: False);
            
                Field<InductionCoilChannelGraphType, InductionCoilChannel>("InductionCoilChannels")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilChannelGraphType>(
                            "{ Name = EntityName "InductionInverterChannelConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionInverterChannelConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InverterChannelId"
                      IsNullable = false }; ForeignKey { Type = Guid
                                                         Name = "CoilChannel0Id"
                                                         IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilChannel1Id"
                      IsNullable = true };
         Navigation { Type = TableName "InductionCoilChannel"
                      Name = "CoilChannel0"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilChannel"
                      Name = "CoilChannel1"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "InductionZeroCrossConfigurationInverterChannel0s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "InductionZeroCrossConfigurationInverterChannel1s"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "InverterChannelId"
              Type = Id Guid
              IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names = [RelationName "CoilChannel0"; RelationName "CoilChannel1"]
        TargetTable =
         { Name = TableName "InductionCoilChannel"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilChannelId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "CoilType"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CoilPowerTableId"
                          IsNullable = true }; ForeignKey { Type = Byte
                                                            Name = "CoilNtcGiid"
                                                            IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "AssistedCookingNtcGiid"
                          IsNullable = true };
             Primitive { Type = Int
                         Name = "ResonanceCapacity"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ResonantCapacitorPresent"
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
             Navigation
               { Type = TableName "InductionCoilPowerTableConfiguration"
                 Name = "CoilPowerTable"
                 IsNullable = true
                 IsCollection = false };
             Navigation { Type = TableName "InductionCoilType"
                          Name = "CoilTypeNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InductionInverterChannelConfigurationCoilChannel0s"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InductionInverterChannelConfigurationCoilChannel1s"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilChannel"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InductionZeroCrossConfiguration"
        TargetTable =
         { Name = TableName "InductionZeroCrossConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ZeroCrossConfigId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "HeatSink0Giid"
                          IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "HeatSink1Giid"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel0Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel1Id"
                          IsNullable = true }; Primitive { Type = String
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
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel0s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel0"
                 IsNullable = true
                 IsCollection = false };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel1"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "InductionZeroCrossConfiguration"
        KeyType = Guid }] }-InductionCoilChannel-loader",
                            async ids => 
                            {
                                Expression<Func<InductionCoilChannel, bool>> expr = x => !ids.Any()
                                    \|\| (x.CoilChannel0 != null && ids.Contains((Guid)x.CoilChannel0))
\|\| (x.CoilChannel1 != null && ids.Contains((Guid)x.CoilChannel1));

                                var data = await dbContext.InductionCoilChannels
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.CoilChannel0,
x.CoilChannel1
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.InductionCoilChannels);
                    });
            
			
                Field<InductionZeroCrossConfigurationGraphType, InductionZeroCrossConfiguration>("InductionZeroCrossConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionZeroCrossConfigurationGraphType>>(
                            "{ Name = EntityName "InductionInverterChannelConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "InductionInverterChannelConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InverterChannelId"
                      IsNullable = false }; ForeignKey { Type = Guid
                                                         Name = "CoilChannel0Id"
                                                         IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "CoilChannel1Id"
                      IsNullable = true };
         Navigation { Type = TableName "InductionCoilChannel"
                      Name = "CoilChannel0"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilChannel"
                      Name = "CoilChannel1"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "InductionZeroCrossConfigurationInverterChannel0s"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "InductionZeroCrossConfiguration"
                      Name = "InductionZeroCrossConfigurationInverterChannel1s"
                      IsNullable = false
                      IsCollection = true }] }
  Fields = [{ Name = "InverterChannelId"
              Type = Id Guid
              IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names = [RelationName "CoilChannel0"; RelationName "CoilChannel1"]
        TargetTable =
         { Name = TableName "InductionCoilChannel"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CoilChannelId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "CoilType"
                                                            IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CoilPowerTableId"
                          IsNullable = true }; ForeignKey { Type = Byte
                                                            Name = "CoilNtcGiid"
                                                            IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "AssistedCookingNtcGiid"
                          IsNullable = true };
             Primitive { Type = Int
                         Name = "ResonanceCapacity"
                         IsNullable = true };
             Primitive { Type = Bool
                         Name = "ResonantCapacitorPresent"
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
             Navigation
               { Type = TableName "InductionCoilPowerTableConfiguration"
                 Name = "CoilPowerTable"
                 IsNullable = true
                 IsCollection = false };
             Navigation { Type = TableName "InductionCoilType"
                          Name = "CoilTypeNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InductionInverterChannelConfigurationCoilChannel0s"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InductionInverterChannelConfigurationCoilChannel1s"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilChannel"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InductionZeroCrossConfiguration"
        TargetTable =
         { Name = TableName "InductionZeroCrossConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ZeroCrossConfigId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "HeatSink0Giid"
                          IsNullable = true };
             ForeignKey { Type = Byte
                          Name = "HeatSink1Giid"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel0Id"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "InverterChannel1Id"
                          IsNullable = true }; Primitive { Type = String
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
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel0s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel1s"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionIpcdetail"
                          Name = "InductionIpcdetailZeroCrossChannel2s"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel0"
                 IsNullable = true
                 IsCollection = false };
             Navigation
               { Type = TableName "InductionInverterChannelConfiguration"
                 Name = "InverterChannel1"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "InductionZeroCrossConfiguration"
        KeyType = Guid }] }-InductionZeroCrossConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionZeroCrossConfigurations
                                    .Where(x => x.InductionZeroCrossConfiguration != null && ids.Contains((Guid)x.InductionZeroCrossConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionZeroCrossConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InductionZeroCrossConfigurations);
                    });
            
        }
    }
}
            
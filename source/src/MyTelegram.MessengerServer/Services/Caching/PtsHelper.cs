﻿namespace MyTelegram.MessengerServer.Services.Caching;

public class PtsHelper : IPtsHelper
{
    private readonly ConcurrentDictionary<long, PtsCacheItem> _ownerToPtsDict = new();
    private readonly int _syncToReadModelIntervalCount = 1000;

    public int GetCachedPts(long ownerId)
    {
        if (_ownerToPtsDict.TryGetValue(ownerId, out var cacheItem))
        {
            return cacheItem.Pts;
        }

        return 0;
    }

    //public async Task AddPtsAsync(long ownerId,int currentPts){}

    public Task IncrementPtsAsync(long ownerId, int currentPts, int ptsCount = 1)
    {
        if (_ownerToPtsDict.TryGetValue(ownerId, out var cacheItem))
        {
            if (ptsCount == 1)
            {
                cacheItem.IncrementPts();
            }
            else
            {
                cacheItem.AddPts(ptsCount);
            }

            if (cacheItem.Pts < currentPts)
            {
                cacheItem.AddPts(currentPts - cacheItem.Pts);
            }

            //if (cacheItem.Pts + 1 < currentPts)
            //{
            //    cacheItem.AddPts(currentPts - cacheItem.Pts);
            //}
            //else
            //{
            //    cacheItem.IncrementPts();
            //}
        }
        else
        {
            cacheItem = new PtsCacheItem(currentPts);
            _ownerToPtsDict.TryAdd(ownerId, cacheItem);
        }

        if (cacheItem.Pts % _syncToReadModelIntervalCount == 0)
        {
            //var command = new UpdatePtsCommand(PtsId.Create(ownerId), ownerId, currentPts);
            //await _commandBus.PublishAsync(command, CancellationToken.None).ConfigureAwait(false);
        }

        return Task.CompletedTask;
    }
}
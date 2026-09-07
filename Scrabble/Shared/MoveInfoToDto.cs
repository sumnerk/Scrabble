using Scrabble.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using Scrabble.Core.Types;

namespace Scrabble.Shared
{
    public class MoveInfoToDto
    {
        public static MoveInfoDto GetMoveInfoDto(MoveInfo mi)
        {
            var miDto = new MoveInfoDto();

            miDto.MoveNumber = mi.MoveNumber;
            miDto.Action = mi.Action;
            miDto.Who = mi.Who;
            miDto.Words = mi.Words;
            miDto.MoveDuration = mi.MoveDuration;
            miDto.TotalMoveDuration = mi.TotalMoveDuration;
            miDto.Score = mi.Score;
            miDto.Description = mi.Description;

            return miDto;
        }
    }
}

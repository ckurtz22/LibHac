﻿using LibHac.FsSrv.Creators;

namespace LibHac.FsSrv
{
    public class FileSystemProxyConfiguration
    {
        public FileSystemCreators FsCreatorInterfaces { get; set; }
        public ProgramRegistryServiceImpl ProgramRegistryServiceImpl { get; set; }
    }
}

/* Copyright (C) Atomix OS Development, Inc - All Rights Reserved
* Unauthorized copying of this file, via any medium is strictly prohibited
* Proprietary and confidential
* Written by SANDEEP ILIGER <sandeep.iliger@gmail.com>, 08-2014
*/

using System;
using System.Collections.Generic;

namespace Kernel_alpha.FileSystem.FAT
{
	public class FatFileLocation
	{
		public uint FirstCluster;

		public uint DirectorySector;

		public uint DirectorySectorIndex;

		public bool directory;

		private bool IsDirectory { get { return directory; } }

        public uint Size;

	    public FatFileLocation()
        {

        }

        public FatFileLocation(uint startCluster, uint directorySector, uint directoryIndex, bool directory, uint size)
		{
			this.FirstCluster = startCluster;
			this.DirectorySector = directorySector;
			this.DirectorySectorIndex = directoryIndex;
			this.directory = directory;
            this.Size = size;
		}
	}
}
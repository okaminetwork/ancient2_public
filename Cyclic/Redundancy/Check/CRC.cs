﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Cyclic.Redundancy.Check
{
	public sealed class CRC : HashAlgorithm
	{
		public CRC() : this(3988292384U, uint.MaxValue)
		{
		}
		public CRC(uint polynomial, uint seed)
		{
			this.table = CRC.InitializeTable(polynomial);
			this.hash = seed;
			this.seed = seed;
		}

		public override void Initialize()
		{
			this.hash = this.seed;
		}

		protected override void HashCore(byte[] buffer, int start, int length)
		{
			this.hash = CRC.CalculateHash(this.table, this.hash, buffer, start, length);
		}

		protected override byte[] HashFinal()
		{
			byte[] array = CRC.UInt32ToBigEndianBytes(~this.hash);
			this.HashValue = array;
			return array;
		}

		public override int HashSize
		{
			get
			{
				return 32;
			}
		}

		public static uint Compute(byte[] buffer)
		{
			return CRC.Compute(uint.MaxValue, buffer);
		}

		public static uint Compute(uint seed, byte[] buffer)
		{
			return CRC.Compute(3988292384U, seed, buffer);
		}

		public static uint Compute(uint polynomial, uint seed, byte[] buffer)
		{
			return ~CRC.CalculateHash(CRC.InitializeTable(polynomial), seed, buffer, 0, buffer.Length);
		}

		private static uint[] InitializeTable(uint polynomial)
		{
			if (polynomial == 3988292384U && CRC.defaultTable != null)
			{
				return CRC.defaultTable;
			}
			uint[] array = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ polynomial);
					}
					else
					{
						num >>= 1;
					}
				}
				array[i] = num;
			}
			if (polynomial == 3988292384U)
			{
				CRC.defaultTable = array;
			}
			return array;
		}

		private static uint CalculateHash(uint[] table, uint seed, IList<byte> buffer, int start, int size)
		{
			uint num = seed;
			for (int i = start; i < size - start; i++)
			{
				num = (num >> 8 ^ table[(int)((UIntPtr)((uint)buffer[i] ^ (num & 255U)))]);
			}
			return num;
		}

		private static byte[] UInt32ToBigEndianBytes(uint uint32)
		{
			byte[] bytes = BitConverter.GetBytes(uint32);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			return bytes;
		}

		public const uint DefaultPolynomial = 3988292384U;
		public const uint DefaultSeed = 4294967295U;
		private static uint[] defaultTable;
		private readonly uint seed;
		private readonly uint[] table;
		private uint hash;
	}
}

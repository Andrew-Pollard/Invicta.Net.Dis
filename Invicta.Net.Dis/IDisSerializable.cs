using System;


namespace Invicta.Net.Dis {

	public interface IDisSerializable {
		void DisSerialize(Span<byte> bytes);
		void DisDeserialize(ReadOnlySpan<byte> bytes);
	}
}
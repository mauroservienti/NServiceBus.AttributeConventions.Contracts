using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
using PublicApiGenerator;
using System.Runtime.CompilerServices;

namespace NServiceBus.AttributeConventions.Contracts.Tests.API
{
    public class APIApprovals
    {
        [Test]
        [UseReporter(typeof(DiffReporter))]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Approve_API()
        {
            var publicApi = typeof(MessageAttribute).Assembly.GeneratePublicApi();

            Approvals.Verify(publicApi);
        }
    }
}

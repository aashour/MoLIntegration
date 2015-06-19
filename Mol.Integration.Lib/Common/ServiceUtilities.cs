using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Mol.Integration.Lib.Common
{
    public class ServiceUtilities<T>
    {
        public static bool Use(Action<T> action)
        {
            ChannelFactory<T> factory = new ChannelFactory<T>("*");
            T client = factory.CreateChannel();

            bool success = false;
            try
            {
                action(client);
                ((IClientChannel)client).Close();
                factory.Close();
                success = true;
            }
            catch (CommunicationException)
            {
                throw;
            }
            catch (TimeoutException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (!success)
                {
                    ((IClientChannel)client).Abort();
                    factory.Abort();
                }
            }

            return success;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Server_Application.Model
{
    [ServiceContract]
    interface IManagerContract
    {
        /// <summary>
        /// Добавить нового клиента на сервере
        /// </summary>
        /// <param name="client"> Новый клиент</param>
        /// <returns>Возвращает 0, если операция успешна</returns>
        [OperationContract]
        int AddNewClient(Client client);

        /// <summary>
        /// Добавление новой новости
        /// </summary>
        /// <param name="news">Новая новость</param>
        [OperationContract]
        void AddNew(New news);
        /// <summary>
        /// Удаление новости
        /// </summary>
        /// <param name="news">Новость которую надо удалить с сервера</param>
        [OperationContract]
        void DeleteNew(New news);
        /// <summary>
        /// Получить переписку с конкретным клиентом
        /// </summary>
        /// <param name="user">Клиент</param>
        /// <returns>Масив собщений(переписка)</returns>
        [OperationContract]
        MessageClass[] GetMessage(ChatUser user);
        [OperationContract]
        ChatUser[] GetChatUsers();
        /// <summary>
        /// Отправить собщение клиенту
        /// </summary>
        /// <param name="user">Клиент которуму отправляем собщение</param>
        /// <param name="message">Собщение которое отправляется</param>
        [OperationContract]
        void SendMessade(ChatUser user, MessageClass message);

        [OperationContract]
        byte[] getsession();
        void SendImage(string name, byte[] array);
        [OperationContract]
        byte[] GetImage(string name);
        [OperationContract]
        FullClientInfo GetClient(int Id);
        [OperationContract]
        ShortClientInfo[] GetShortClientInfo(string name, string lastname);
        
    }
}

using System;
using System.Configuration;
using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;

namespace Bot.Application.Dialogs
{
    [Serializable]
    public class QnaDialog : QnAMakerDialog
    {
        public QnaDialog() : base(new QnAMakerService(new QnAMakerAttribute(
                                                            ConfigurationManager.AppSettings["QnaSubscriptionKey"], 
                                                            ConfigurationManager.AppSettings["QnaKnowledgebaseId"], 
                                                            "Não encontrei sua resposta",
                                                            0.5)))
        {
            
        }
    }
}
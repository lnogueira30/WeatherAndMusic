using prmToolkit.NotificationPattern;
using System;
using WeatherAndMusic.Domain.Arguments.Note;
using WeatherAndMusic.Domain.Arguments.WMUser;
using WeatherAndMusic.Domain.Entities;
using WeatherAndMusic.Domain.Interfaces;
using WeatherAndMusic.Domain.Interfaces.Repositories;

namespace WeatherAndMusic.Domain.Services
{
    public class ServiceNote : Notifiable, IServiceNote
    {
        private readonly IRepositoryNote _repository;

        public ServiceNote(IRepositoryNote repository)
        {
            _repository = repository;
        }

        public AddNoteResponse Add(AddNoteRequest request)
        {

            Note note = new Note(request.WMUserId, request.Text);

            _repository.Add(note);

            return (AddNoteResponse)note;
        }

        public RemoveNoteResponse Delete(DeleteNoteRequest request)
        {
            throw new NotImplementedException();
        }

        public EditNoteResponse Edit(EditNoteRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

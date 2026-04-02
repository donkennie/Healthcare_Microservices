
using AppointmentsApi.Models;
using MediatR;
using System;

namespace AppointmentsApi.Queries.GetAppointments;

public record GetAppointmentsQuery() : IRequest<List<Appointment>>;
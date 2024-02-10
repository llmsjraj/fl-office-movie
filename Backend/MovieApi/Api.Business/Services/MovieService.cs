﻿using Api.Business.DTOs;
using Api.Business.Repository;
using Api.Business.Repository.Data;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;
        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task<ApiResponse<MovieDto>> AddAsync(MovieDto movie)
        {
            var newMovie = _mapper.Map<Movie>(movie);
            var addedMovie = await _movieRepository.AddAsync(newMovie);
            var dto = _mapper.Map<MovieDto>(addedMovie);
            return new ApiResponse<MovieDto>()
            {
                Data = dto,
                Success = true,
                StatusCode = 201
            };
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<MovieDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<MovieDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(MovieDto movie)
        {
            throw new NotImplementedException();
        }
    }
}

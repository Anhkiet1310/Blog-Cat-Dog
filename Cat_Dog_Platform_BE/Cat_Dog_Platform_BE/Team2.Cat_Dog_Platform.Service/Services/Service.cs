﻿using AutoMapper;
using Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Repositoty.Repository;

namespace Cat_Dog_Platform_BE.Team2.Cat_Dog_Platform.Service.Services
{
    public class Service
    {
        protected readonly IMapper mapper;
        protected readonly AccountRepository accountRepo;
        protected readonly BlogRepository blogRepo;
        protected readonly TagRepository tagRepo;
        protected readonly PostRepository postRepo;

        public Service(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public Service(IMapper _mapper, AccountRepository? _accountRepo, BlogRepository? _blogRepo, TagRepository? _tagRepo,
            PostRepository? _postRepo)
        {
            mapper = _mapper;
            accountRepo = _accountRepo;
            blogRepo = _blogRepo;
            tagRepo = _tagRepo;
            postRepo = _postRepo;

        }
    }
}
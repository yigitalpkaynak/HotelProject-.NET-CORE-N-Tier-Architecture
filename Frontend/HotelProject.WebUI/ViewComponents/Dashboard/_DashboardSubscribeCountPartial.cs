using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;
using HotelProject.WebUI.Dtos.FollowersDto;
using Newtonsoft.Json;



namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Shut it down because of slow running of apis. You can turn on and pass datas to view through ViewBags.

            //ResultInstagramFollowersDto resultInstagramFollowersDtos = new ResultInstagramFollowersDto();

            //var client = new HttpClient();
            //var request = new HttpRequestMessage
            //{
            //    Method = HttpMethod.Get,
            //    RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/didemgeziyor"),
            //    Headers =
            //    {
            //        { "x-rapidapi-key", "aa4e25c8e7msh2a2035bc5d44420p180c90jsn6c4629a6a02f" },
            //        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
            //    },
            //};
            //using (var response = await client.SendAsync(request))
            //{
            //    response.EnsureSuccessStatusCode();
            //    var body = await response.Content.ReadAsStringAsync();
            //    resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
            //    ViewBag.IGFollowers = resultInstagramFollowersDtos.followers;
            //    ViewBag.IGFollowing = resultInstagramFollowersDtos.following;
            //}

            //var client2 = new HttpClient();
            //var request2 = new HttpRequestMessage
            //{
            //    Method = HttpMethod.Get,
            //    RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=murattyucedag"),
            //    Headers =
            //    {
            //        { "x-rapidapi-key", "aa4e25c8e7msh2a2035bc5d44420p180c90jsn6c4629a6a02f" },
            //        { "x-rapidapi-host", "twitter32.p.rapidapi.com" },
            //    },
            //};
            //using (var response2 = await client2.SendAsync(request2))
            //{
            //    response2.EnsureSuccessStatusCode();
            //    var body2 = await response2.Content.ReadAsStringAsync();
            //    ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
            //    ViewBag.TwitterFollowers = resultTwitterFollowersDto.data.user_info.followers_count;
            //    ViewBag.TwitterFollowings = resultTwitterFollowersDto.data.user_info.friends_count;
            //}

            //var client3 = new HttpClient();
            //var request3 = new HttpRequestMessage
            //{
            //    Method = HttpMethod.Get,
            //    RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fmuratyucedag%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false"),
            //    Headers =
            //    {
            //        { "x-rapidapi-key", "aa4e25c8e7msh2a2035bc5d44420p180c90jsn6c4629a6a02f" },
            //        { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
            //    },
            //};
            //using (var response3 = await client3.SendAsync(request3))
            //{
            //    response3.EnsureSuccessStatusCode();
            //    var body3 = await response3.Content.ReadAsStringAsync();
            //    ResultLinkedInFollowersDto resultLinkedInFollowersDto = JsonConvert.DeserializeObject<ResultLinkedInFollowersDto>(body3);
            //    ViewBag.LinkedInFollowers = resultLinkedInFollowersDto.data.follower_count;
            //}

            return View();
        }
    }
}

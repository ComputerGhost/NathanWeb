<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="NathanWeb.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phContent" runat="server">
<main>
    <article>

        <section>
            <figure style="float: right">
                <img alt="profile picture" src="/assets/profile.jpg" style="height: 177px; width: 130px;">
            </figure>
            <p>I'm a foodie and a professional programmer. A lot of my time is spent studying and practicing, with a fair amount of breaks to find a new experience. The most normal thing about me is how I tie my shoes. The oddest is that I don't own or want a television. It is a good life.</p>
        </section>

        <section>
            <h2>Programming</h2>
            <p>I started when I was 14, when my dad gave me an old computer. It came with a word processor, a text editor, and a compiler. If I wanted anything else, I had to make it.</p>
            <p>Now, years later, I'm a damn good programmer. I'm commonly complimented for being smart, but I think that misses the point. Skills don't come free. I had to earn this one with hard work and dedication. Most people could do the same.</p>
            <p>&nbsp;</p>
        </section>

        <section>
            <h2>Food</h2>
            <p>If I weren't a programmer, I would be either a cook or a <del>professional glutton</del> taste tester. I love delicious food! Here are some of my creations:</p>
            <div class="columns add-content-margin">
                <div class="column">
                    <img src="/assets/fish.jpg" style="width: 233px; height: 323px;">
                </div>
                <div class="column remove-text">
                    <img src="/assets/chicken_and_salad.jpg" style="height: 150px; width: 308px;">
                    <div style="height: 4px;"></div>
                    <img src="/assets/mushroom_burger.jpg" style="height: 169px; width: 308px;">
                </div>
                <div class="column">
                    <img src="/assets/potato_soup.jpg" style="width: 251px; height: 323px;">
                </div>
            </div>
        </section>

        <section>
            <h2>Contact</h2>
            <p>My personal email address is <a href="mailto:nathan.belue@gmail.com">nathan.belue@gmail.com</a>. If you have a different one for me, then use the one you have. I check my emails at least twice a month.</p>
        </section>

    </article>
</main>
</asp:Content>

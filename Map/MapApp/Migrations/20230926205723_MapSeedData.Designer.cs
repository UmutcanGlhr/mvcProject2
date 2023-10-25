﻿// <auto-generated />
using MapApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MapApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230926205723_MapSeedData")]
    partial class MapSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("MapApp.Models.Map", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("mapSvg")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Maps");

                    b.HasData(
                        new
                        {
                            id = 1,
                            mapSvg = "M 369.8,190.4 369.9,189.4 371.1,188.5 371.6,188.6 371.7,189.7 373.7,191.5 374.7,191.5 374.9,191.7 375.5,191.8 376.2,191.4 377.2,191.6 378.0,191.7 379.3,192.2 380.0,192.6 380.8,192.6 381.4,192.8 381.9,193.6 382.3,193.6 382.6,194.3 382.8,194.6 383.3,195.6 383.5,196.4 383.2,197.6 383.3,198.7 384.0,200.3 388.6,203.0 389.5,203.0 390.2,203.7 390.5,203.5 391.0,203.5 391.3,203.2 391.8,203.3 392.4,203.5 393.2,203.5 393.4,203.3 393.8,203.6 394.5,203.5 394.7,203.5 394.9,203.6 395.0,203.7 395.0,204.1 395.2,204.1 395.6,203.9 395.9,203.9 396.0,203.8 396.0,203.7 395.9,203.4 396.1,202.8 397.1,201.9 399.1,201.4 400.4,201.8 401.4,200.9 401.8,201.1 402.1,201.5 402.8,200.9 403.2,199.6 403.6,199.7 404.0,200.1 404.9,200.2 405.9,200.2 406.6,201.4 408.6,202.1 409.7,201.9 410.3,201.2 411.2,200.9 411.9,200.7 412.4,200.6 413.0,200.7 414.1,200.5 415.0,200.5 415.7,200.8 416.8,200.5 417.1,200.6 418.7,201.1 419.4,201.8 420.0,202.1 420.5,201.6 421.7,201.2 423.0,200.5 423.6,200.5 423.8,200.4 424.1,200.7 424.6,200.9 424.8,200.9 425.0,201.0 425.2,201.4 425.5,201.4 425.7,201.5 426.0,201.6 426.3,201.5 426.5,201.6 426.7,201.8 426.7,201.9 426.7,202.1 426.4,202.3 426.2,202.5 425.4,202.7 424.9,202.6 423.7,203.0 423.5,203.2 423.5,203.5 424.1,203.8 424.5,204.9 425.2,204.3 425.8,204.3 426.1,204.6 427.2,204.4 427.8,203.9 428.7,203.6 428.7,202.7 429.0,202.2 429.6,202.3 429.8,202.8 430.5,203.2 430.9,203.8 431.5,204.3 432.1,204.6 432.6,204.6 433.1,203.9 433.6,203.3 434.0,203.1 434.3,203.0 435.0,203.0 435.9,203.1 437.0,203.6 437.4,203.7 438.3,204.2 438.9,204.5 439.8,204.5 440.1,204.4 440.8,204.3 442.1,203.7 443.3,202.6 443.4,202.2 443.6,201.9 444.3,201.5 444.7,202.0 444.3,202.5 444.1,203.7 444.0,204.1 443.5,205.1 443.4,205.4 443.5,205.7 444.0,205.9 444.5,205.9 445.0,205.7 445.6,205.3 446.3,204.8 446.7,204.5 447.5,204.5 447.6,204.9 447.6,205.3 447.2,205.7 447.0,206.4 446.6,206.6 446.2,207.3 446.2,207.5 446.5,208.8 447.0,209.3 447.7,209.6 447.9,209.8 448.3,209.9 449.0,209.7 449.0,209.2 449.1,209.2 449.3,209.6 449.5,209.8 449.6,210.2 449.6,211.2 449.3,212.4 449.6,213.1 450.6,213.9 451.4,215.0 451.5,215.0 451.6,216.1 452.3,216.7 452.7,217.0 453.0,217.5 453.5,218.1 454.4,218.4 455.8,218.5 457.4,217.9 458.1,217.7 458.4,218.0 458.2,218.2 458.2,218.3 458.3,218.4 458.5,218.4 458.5,218.6 458.5,218.7 458.6,218.6 458.7,218.5 459.0,218.6 459.0,218.7 459.0,218.9 459.1,218.9 459.2,219.0 459.3,218.8 459.4,218.8 459.3,218.9 459.3,219.1 459.0,219.2 459.0,219.1 458.7,219.2 458.7,219.4 458.5,219.5 458.5,219.4 458.4,219.3 458.3,219.4 458.4,219.6 458.2,219.5 458.1,219.7 458.2,219.9 457.8,219.9 457.8,219.9 457.8,220.1 457.7,220.1 457.6,220.0 457.5,220.0 457.5,220.2 457.4,220.3 457.3,220.3 457.5,220.4 457.3,220.5 457.3,220.6 457.4,220.8 457.6,220.9 457.7,221.1 457.7,221.1 457.8,221.0 458.0,221.1 458.0,221.1 458.3,221.1 458.4,220.9 458.4,220.8 458.5,220.8 458.6,221.0 458.5,221.1 458.5,221.1 458.8,221.1 458.8,221.0 458.8,220.9 458.6,220.7 458.6,220.7 458.8,220.6 458.9,220.8 459.0,220.8 459.1,220.8 459.1,220.7 459.1,220.4 459.2,220.3 459.3,220.3 459.4,220.4 459.4,220.5 459.5,220.6 459.6,220.6 459.7,220.5 459.6,220.3 459.8,220.1 460.0,220.1 460.1,220.2 460.0,220.3 459.9,220.4 460.0,220.6 460.0,220.6 460.1,220.4 460.1,220.2 460.2,220.3 460.2,220.5 460.5,220.5 460.6,220.4 460.6,220.2 460.7,220.2 460.8,220.3 460.9,220.3 461.0,220.4 461.4,220.5 461.4,220.6 461.3,220.8 461.0,221.0 460.9,221.3 460.7,221.6 460.7,221.7 460.6,221.8 459.9,222.8 459.9,222.9 460.1,223.0 460.4,223.0 460.7,223.2 460.9,223.5 460.7,224.7 457.1,224.7 455.9,225.0 454.4,226.0 453.1,227.2 452.3,229.6 451.2,231.0 451.0,232.5 451.1,233.5 451.9,235.1 453.8,236.4 456.7,236.5 458.5,237.4 459.3,237.8 459.8,238.7 462.0,238.7 462.9,239.3 463.7,240.1 465.2,242.3 465.3,243.8 463.8,246.0 463.5,247.0 464.0,247.7 464.6,248.5 465.5,249.2 465.8,250.1 465.9,250.4 466.6,251.2 466.8,251.7 466.1,252.6 466.1,252.9 466.3,253.4 466.6,253.9 468.1,254.3 468.5,254.9 468.5,255.2 468.2,255.5 468.1,256.1 467.7,256.6 467.9,257.1 468.1,257.3 468.3,257.6 468.2,257.9 468.6,259.0 468.3,259.8 468.2,261.8 467.2,262.8 466.9,263.8 466.6,264.8 467.0,265.0 468.2,266.7 467.7,267.3 467.3,267.4 466.8,268.5 467.1,269.0 467.6,269.4 468.1,269.3 468.4,269.8 468.9,269.8 469.0,270.7 469.9,271.6 470.9,274.0 470.9,275.2 469.9,276.9 468.7,277.9 467.1,278.9 466.6,278.9 466.0,278.9 465.4,280.3 464.9,280.4 464.7,280.4 464.6,280.5 464.3,280.4 464.0,280.6 463.9,280.5 463.6,280.5 463.3,280.7 463.2,280.8 463.2,280.9 463.4,281.6 463.2,282.3 463.0,282.6 462.8,282.7 462.6,282.7 462.4,282.7 462.0,283.2 461.8,283.2 460.8,284.1 460.5,284.6 460.4,285.0 460.3,285.1 460.2,285.1 460.1,285.1 459.5,284.8 459.4,284.8 459.3,284.8 458.9,285.5 458.7,285.6 458.6,285.6 458.0,285.1 457.5,285.2 457.5,285.9 456.9,285.9 456.4,285.3 456.0,285.8 456.0,287.0 456.2,289.1 458.8,291.4 458.5,291.5 457.2,291.7 456.0,291.6 453.6,292.0 452.6,292.4 450.9,293.9 450.2,295.9 448.9,297.3 446.6,297.6 442.8,297.4 441.0,297.1 439.6,297.9 439.1,298.5 435.9,298.6 435.1,298.3 435.1,296.1 434.8,295.2 434.0,294.6 432.4,294.4 431.1,294.0 429.6,293.1 427.9,291.7 427.5,290.9 428.7,288.4 428.2,286.7 425.2,286.7 424.7,286.4 423.4,284.9 421.8,284.9 420.4,284.5 419.7,284.1 419.1,283.3 418.3,281.4 418.3,280.0 419.2,278.5 419.2,277.5 418.6,277.0 418.0,277.0 417.3,277.6 416.5,279.1 415.6,279.6 413.9,280.0 413.2,280.0 412.3,279.2 410.8,279.1 409.2,278.8 407.0,278.6 403.7,277.6 402.9,277.7 400.1,279.4 400.0,279.7 400.3,280.2 401.4,280.9 402.6,281.6 402.4,283.0 401.4,283.6 399.8,283.4 398.8,283.2 397.3,284.2 396.6,284.9 396.0,284.6 394.2,283.7 392.9,283.0 391.3,282.1 390.3,281.8 389.4,281.7 388.0,282.0 386.7,282.1 386.0,283.0 385.7,283.9 385.7,285.4 386.2,286.5 387.7,288.2 388.9,289.3 388.9,290.0 388.7,291.0 387.9,291.4 386.7,291.4 384.0,290.8 381.4,290.7 379.8,291.4 378.9,293.7 378.8,295.7 377.7,296.2 376.3,296.5 375.7,297.5 375.1,297.9 374.0,297.8 373.0,297.7 372.1,297.2 370.4,295.1 370.3,293.9 369.7,293.8 367.6,294.1 365.9,293.6 364.4,293.7 363.7,293.3 363.1,292.5 362.3,292.2 361.3,291.6 361.1,290.1 361.1,288.8 360.1,287.4 359.6,285.3 358.4,281.9 357.5,280.8 357.1,280.7 356.2,280.7 353.8,281.5 353.3,280.9 352.2,279.7 350.6,277.8 349.9,276.6 350.2,273.9 349.9,272.3 348.1,270.0 346.2,266.7 346.2,265.4 346.9,264.5 349.5,263.2 349.7,263.0 348.7,262.4 347.0,262.0 345.7,260.9 345.3,258.9 345.9,253.5 345.9,251.9 345.1,250.9 343.3,250.0 340.1,248.5 339.0,247.3 338.1,245.7 337.2,242.6 336.3,239.9 336.2,237.7 337.3,237.0 333.8,237.3 331.6,238.0 329.5,237.9 327.6,238.5 325.2,239.8 324.4,239.8 323.6,239.4 323.1,238.9 321.9,237.1 320.9,236.4 320.2,235.4 319.9,234.0 319.9,232.9 320.5,231.6 320.6,230.2 322.0,227.8 324.4,225.7 325.9,223.9 327.3,222.7 328.0,222.0 329.9,221.0 330.9,220.7 332.3,220.2 333.3,220.0 334.5,219.8 335.1,219.9 336.4,220.0 337.1,219.8 338.1,220.0 339.3,220.5 340.0,220.9 340.6,221.0 340.9,221.2 341.3,221.2 342.1,221.7 342.6,222.0 342.5,221.7 342.6,221.2 342.6,220.4 343.2,219.6 343.9,219.4 344.4,219.4 344.2,219.1 343.5,218.9 343.2,218.8 343.2,218.5 343.0,218.3 342.3,216.0 342.7,214.6 342.0,213.3 342.2,212.6 342.3,211.1 342.6,210.8 342.7,211.1 342.9,211.1 342.7,211.4 342.8,211.7 343.4,211.8 343.8,212.2 344.3,212.6 344.7,212.4 344.9,212.4 345.0,212.3 345.0,212.3 345.1,212.3 345.3,212.3 345.8,212.6 346.8,212.4 347.1,211.8 347.2,211.1 347.4,211.1 347.7,211.3 347.8,211.1 347.7,210.3 347.7,210.2 347.4,210.1 347.2,210.1 347.0,209.4 346.7,209.2 346.5,208.9 346.1,208.8 346.0,208.7 346.2,208.5 346.4,208.7 346.7,208.7 346.9,208.5 347.0,208.5 347.3,208.2 347.5,208.1 347.4,208.0 347.5,207.8 347.5,207.5 347.7,207.5 348.1,207.2 347.8,206.5 347.6,206.4 347.6,206.2 348.1,206.0 348.1,205.9 348.5,205.8 348.5,205.4 348.6,205.2 348.6,204.9 348.8,204.8 348.8,204.6 349.1,204.2 349.1,205.0 348.9,205.4 349.3,205.5 349.6,205.4 350.3,205.6 350.6,205.6 350.8,205.7 351.2,205.4 352.7,205.9 354.0,205.5 355.3,204.3 356.7,203.1 357.2,202.2 357.8,201.0 358.2,200.3 359.0,199.3 359.1,198.4 360.1,197.3 360.5,196.7 360.3,194.8 361.1,194.9 361.7,194.4 362.7,194.6 362.8,193.7 364.3,193.5 366.7,192.2 367.3,191.8 367.9,191.5 369.7,190.7 369.8,190.4Z"
                        },
                        new
                        {
                            id = 2,
                            mapSvg = "M 382.3,193.6 382.6,192.5 383.1,191.9 383.0,191.3 383.7,190.7 384.3,190.2 385.1,189.9 385.5,189.2 386.7,189.4 387.1,189.3 388.5,189.2 389.6,189.3 390.3,188.5 391.0,187.3 391.6,186.7 392.0,186.0 392.7,185.8 393.3,185.9 394.0,185.9 395.8,185.8 397.6,185.6 398.5,185.4 399.9,184.4 399.7,183.3 398.1,183.4 397.8,181.8 398.1,181.2 398.8,180.5 398.9,179.7 399.2,179.2 399.4,177.7 399.4,176.4 399.6,174.9 399.2,173.8 399.2,173.3 399.8,172.9 400.3,172.3 400.5,171.8 402.3,170.8 403.5,171.1 404.4,171.5 406.1,172.4 406.3,173.3 406.8,173.7 409.0,173.9 409.9,173.7 410.3,173.8 410.6,174.0 411.1,173.9 411.6,174.1 412.2,173.8 412.5,173.8 412.8,174.0 413.3,173.5 414.1,172.7 413.9,172.5 414.1,172.4 414.4,172.6 414.5,172.8 414.8,172.8 414.9,173.0 415.1,173.1 415.3,173.3 415.5,173.9 415.6,174.1 415.8,173.9 416.1,174.1 416.3,174.1 416.8,174.4 417.0,174.3 417.0,174.1 417.2,174.0 417.3,173.9 417.5,173.7 417.7,173.4 418.0,173.0 418.4,173.0 418.7,172.7 419.0,172.8 419.1,172.6 419.4,172.6 419.4,172.7 419.8,172.6 419.9,172.9 419.9,173.1 420.1,173.5 420.6,173.5 422.4,172.7 422.9,171.9 423.3,171.3 423.7,170.9 424.1,170.7 424.6,170.8 424.8,170.9 425.1,170.6 425.7,170.7 426.1,170.9 426.2,170.8 426.3,170.9 426.4,171.1 426.9,171.2 427.4,171.2 427.5,171.4 428.0,171.5 427.7,172.3 426.9,174.1 427.1,174.6 425.7,175.7 424.3,176.5 423.8,176.9 423.5,177.7 423.3,178.7 424.0,179.3 424.6,178.9 425.7,178.7 426.6,178.7 427.3,178.3 428.0,178.3 428.5,177.9 429.3,177.6 429.8,177.7 430.0,177.3 430.9,177.1 431.3,177.3 431.6,177.1 432.1,177.0 432.2,177.3 432.9,178.1 434.2,178.4 434.7,178.7 435.3,178.9 435.5,179.8 436.2,179.4 438.2,180.1 438.4,180.6 438.6,180.3 439.1,180.1 439.3,180.1 439.9,179.6 440.8,179.2 441.0,179.0 442.0,178.5 442.7,177.8 443.1,177.5 444.0,177.1 444.4,177.1 445.7,176.7 445.9,176.4 446.4,176.4 446.3,176.7 446.1,176.8 446.0,176.9 446.1,177.2 446.1,177.3 446.2,177.4 446.3,177.5 446.5,177.5 446.6,177.4 446.7,177.4 446.8,177.2 446.9,177.2 447.1,177.2 447.1,177.0 447.2,177.0 447.5,176.8 447.7,176.8 447.8,176.7 447.9,176.7 448.0,176.6 448.1,176.7 448.1,176.7 448.5,176.4 448.7,176.5 449.3,176.3 449.6,176.4 449.8,176.1 449.9,176.0 449.8,175.4 450.0,174.7 449.9,174.5 450.2,174.4 450.5,174.2 451.8,174.6 452.4,174.9 453.7,175.6 454.5,175.7 454.9,175.9 455.5,176.0 455.9,176.2 456.5,176.8 457.5,177.2 458.9,176.9 459.5,175.8 460.8,174.8 461.8,173.7 462.7,173.3 463.3,172.3 464.0,172.0 465.0,172.2 465.6,172.2 467.3,171.7 467.6,171.0 468.7,170.1 469.3,168.5 470.5,167.4 471.0,165.9 473.8,165.7 475.5,165.8 476.9,165.7 478.0,165.5 479.3,164.9 479.8,164.3 480.5,163.7 480.3,162.9 480.4,162.2 480.3,161.9 479.9,161.8 478.8,161.8 478.5,161.4 478.4,160.4 479.1,159.4 481.1,157.9 482.1,156.6 482.4,155.2 482.8,154.3 483.1,154.1 483.7,153.8 484.1,153.5 484.7,153.0 485.4,153.2 486.2,153.4 487.1,153.1 487.5,152.4 488.1,151.9 488.6,151.6 489.3,151.8 489.6,152.1 490.0,152.2 490.3,152.3 490.6,152.2 490.9,151.8 491.6,151.5 492.4,150.8 493.0,150.4 494.0,150.3 494.6,150.4 494.9,150.7 495.2,151.2 495.3,152.0 495.5,152.5 495.9,152.6 496.1,152.8 496.3,153.0 496.5,153.1 496.8,153.2 497.1,153.2 497.9,153.1 498.2,153.0 498.3,152.8 498.7,152.4 498.9,152.1 499.3,151.4 499.5,151.0 499.6,150.7 499.6,150.2 499.6,149.7 499.5,149.1 499.4,148.4 499.4,148.1 499.3,147.8 499.1,147.1 499.2,147.0 499.3,146.2 499.4,145.8 499.7,145.6 500.2,144.7 500.2,144.3 500.0,143.7 499.9,142.9 500.1,141.3 500.8,140.6 501.7,140.2 502.7,140.0 504.5,140.5 505.6,141.0 506.4,140.7 507.5,139.5 507.6,137.7 507.2,136.3 507.4,135.3 508.1,134.7 508.6,134.7 509.0,134.6 509.4,134.4 509.5,134.1 510.3,133.6 511.1,133.4 511.5,133.0 511.8,132.9 512.8,133.4 513.5,133.3 514.9,132.9 515.7,132.9 517.8,133.1 519.5,133.6 520.3,134.1 520.8,134.6 521.0,135.2 521.3,135.6 521.4,136.2 521.9,136.8 523.0,138.4 524.1,140.3 525.3,141.0 526.6,142.4 527.5,142.3 527.9,142.6 529.4,142.6 531.3,143.4 532.9,144.0 534.6,145.1 535.1,145.7 535.5,146.6 535.8,148.0 535.9,148.9 535.9,149.9 535.7,151.5 534.7,157.2 535.6,156.4 536.6,155.8 537.6,155.3 538.4,155.3 539.6,155.2 540.4,155.3 541.3,155.6 541.6,155.9 541.8,156.3 542.1,156.5 542.7,157.1 542.8,157.5 542.8,157.9 542.5,158.3 542.2,158.6 541.9,159.1 542.0,159.6 542.3,159.9 543.1,160.3 543.9,160.4 544.4,160.6 544.8,160.7 545.1,160.5 545.5,160.5 545.7,160.5 546.1,160.7 546.9,161.3 547.4,161.3 547.9,161.7 548.6,161.8 549.4,161.7 549.8,161.6 550.2,161.6 550.8,161.1 551.3,160.9 552.2,161.3 554.2,162.1 555.6,163.2 556.2,163.9 557.1,164.7 557.6,165.6 557.9,165.9 558.1,166.2 558.2,166.9 558.3,167.3 558.6,167.8 558.8,168.3 558.8,168.8 558.2,169.9 558.3,170.4 559.2,171.6 559.8,172.7 560.9,173.8 561.2,174.1 561.6,174.3 562.3,174.9 562.6,175.2 562.9,175.4 563.2,175.3 563.3,175.2 563.5,175.2 563.6,174.9 563.9,174.4 564.1,174.0 564.3,173.7 564.7,173.5 564.9,173.4 565.2,173.2 565.7,173.2 566.1,172.6 566.2,172.3 566.6,171.9 567.1,171.8 567.5,171.5 567.6,171.2 567.6,170.6 567.3,170.2 567.0,169.5 567.1,168.8 567.4,168.1 567.6,167.9 568.2,167.5 569.0,167.4 570.4,167.3 571.5,167.1 574.4,167.2 575.1,167.3 575.7,167.6 576.2,168.0 576.6,168.1 577.4,168.4 577.8,168.7 578.7,169.9 579.6,171.7 580.3,172.5 580.6,172.8 581.2,173.0 583.3,172.1 583.6,172.2 583.9,172.2 584.2,172.4 584.5,172.7 585.2,172.8 586.4,172.8 587.5,173.0 588.6,173.1 589.5,173.7 591.0,174.9 591.4,175.7 591.4,175.9 591.5,176.2 591.6,176.4 591.5,176.7 591.5,176.9 591.6,177.1 591.7,177.3 591.6,177.8 591.6,177.9 591.3,178.1 591.1,178.3 590.9,178.2 590.8,178.1 590.6,178.1 590.5,178.5 590.6,178.8 590.5,179.2 590.5,179.3 590.5,179.4 590.3,179.5 590.1,179.5 589.8,179.4 589.7,179.3 589.5,179.0 589.4,178.9 589.3,179.0 589.2,179.1 589.2,179.5 589.3,179.7 589.2,179.8 588.7,180.4 588.6,180.6 588.6,180.8 588.6,181.0 588.8,181.1 588.6,181.3 588.4,181.4 588.0,181.5 587.9,181.6 587.9,181.7 587.9,181.8 588.2,182.0 588.5,182.4 588.6,182.5 588.7,182.9 588.5,183.2 588.4,183.3 588.2,183.3 588.0,183.5 587.8,183.7 587.8,183.8 587.6,184.0 587.5,184.1 587.6,185.0 587.7,185.4 588.9,185.6 589.2,186.6 589.8,187.7 589.6,191.0 588.1,193.3 587.4,194.8 586.5,196.2 585.9,197.2 585.3,197.8 583.5,198.4 582.0,199.4 579.7,200.6 578.5,200.9 577.5,202.5 579.4,204.6 579.8,206.9 577.8,208.5 575.0,210.0 574.7,210.5 574.4,210.8 574.0,211.3 573.7,211.5 573.3,211.1 573.1,210.4 572.9,209.5 572.1,209.2 571.2,210.7 570.8,212.0 570.7,212.9 570.5,213.8 570.3,213.8 570.0,213.8 569.6,214.0 569.1,214.4 568.9,214.4 568.2,214.4 567.8,214.5 567.9,214.9 567.7,214.9 567.1,214.8 567.0,215.3 566.5,215.5 566.5,215.7 566.0,216.1 565.3,216.2 565.2,217.3 565.4,217.8 565.7,217.9 565.8,218.5 565.3,219.1 564.9,219.6 564.5,219.7 564.4,219.9 565.1,220.4 565.2,220.8 564.8,221.5 564.3,221.4 564.1,221.6 563.9,221.6 563.8,221.8 563.8,222.0 563.8,222.3 564.0,222.7 563.9,223.0 563.9,223.1 564.1,223.4 564.8,223.7 564.8,223.9 564.5,224.0 564.4,224.4 564.1,224.6 564.2,224.8 563.8,225.0 563.7,225.6 563.2,226.6 563.2,227.2 563.3,227.5 563.3,227.8 563.4,228.3 563.2,228.4 563.2,229.0 562.5,229.4 562.4,229.8 562.3,230.9 562.4,231.0 562.7,230.6 563.2,230.3 563.5,229.7 563.6,229.5 563.7,229.6 563.7,230.9 563.8,231.0 563.7,231.8 563.3,232.0 562.7,231.9 562.5,231.6 562.2,231.8 562.0,232.4 562.3,233.1 562.1,233.5 561.8,233.4 561.6,233.9 561.6,234.3 560.7,234.1 560.4,234.5 560.2,234.4 560.4,234.1 560.2,233.8 560.1,233.2 559.6,233.1 559.2,233.5 559.2,234.4 559.7,234.9 559.5,235.9 558.1,236.6 558.0,236.9 557.4,237.6 556.8,237.8 556.8,238.8 556.4,239.2 556.6,239.9 557.6,240.5 558.9,240.8 560.0,240.8 560.7,240.7 561.4,240.3 562.0,239.8 562.4,239.1 562.6,239.0 562.9,238.4 563.1,238.2 563.4,238.3 563.3,238.7 563.4,238.8 563.1,239.4 563.5,239.6 563.6,240.0 564.1,240.0 564.4,239.5 565.1,239.6 565.5,239.9 565.5,240.3 565.9,240.6 565.9,240.9 565.8,241.2 566.0,241.5 566.1,241.8 566.4,242.1 566.6,242.1 566.8,242.3 566.4,242.3 566.3,242.4 566.5,242.5 566.6,242.6 566.8,242.7 566.7,242.9 566.7,243.4 566.5,243.7 566.2,244.5 565.8,244.5 565.9,245.0 566.4,245.5 566.0,245.4 566.0,245.7 565.8,246.0 566.3,246.6 566.3,246.8 566.2,246.9 566.2,247.4 566.4,248.0 566.7,248.2 566.7,249.0 566.5,249.1 566.5,249.5 566.2,249.6 565.7,249.5 565.6,249.3 565.2,249.1 564.7,249.5 564.6,249.7 564.9,249.8 565.1,250.3 565.1,250.6 565.3,250.9 566.1,251.1 566.2,251.7 566.1,252.2 566.2,253.0 566.1,253.5 565.8,253.8 568.6,256.1 570.8,257.6 571.8,258.1 572.0,258.2 572.0,258.5 572.1,258.7 572.0,258.9 572.0,259.1 571.8,259.3 571.8,259.7 571.7,260.2 571.5,260.4 571.4,260.7 571.5,260.9 571.6,261.0 572.0,261.4 572.1,261.6 572.1,261.9 571.8,262.2 571.4,262.2 571.2,262.6 571.1,262.8 571.2,263.1 571.4,263.4 571.8,263.8 572.1,263.9 572.7,264.5 572.8,264.6 573.0,264.6 573.1,264.5 573.5,264.2 573.7,264.2 573.9,264.2 574.0,264.4 574.0,264.6 574.0,265.5 574.9,266.7 574.8,267.3 575.0,267.6 575.6,267.7 575.5,268.3 576.0,268.5 576.2,268.3 576.4,268.1 576.7,268.2 576.7,268.4 576.5,268.7 576.8,269.4 577.1,269.7 577.6,269.9 577.6,270.0 577.3,270.2 577.3,270.4 577.0,270.7 577.0,270.9 577.1,271.1 577.1,271.2 576.9,271.2 576.2,270.9 576.0,270.9 575.8,271.2 575.6,271.6 575.7,271.9 575.9,272.0 576.2,272.3 576.3,272.5 576.6,272.5 576.7,272.7 576.8,273.5 577.0,273.7 577.4,273.7 577.7,273.7 577.9,273.9 578.2,274.2 578.8,274.4 579.1,274.2 579.2,274.2 579.3,274.3 579.7,274.3 580.0,274.7 580.2,274.8 580.3,274.8 580.4,275.1 580.7,275.4 581.0,275.8 581.1,276.3 581.4,277.0 582.0,278.4 583.1,281.1 584.1,282.6 586.6,284.3 587.1,284.7 591.3,287.4 593.1,288.9 593.2,288.8 595.1,291.0 597.0,292.0 597.5,292.4 597.9,292.8 598.4,294.1 598.9,295.2 600.4,295.4 603.1,295.2 604.7,295.4 605.4,295.6 606.7,296.5 607.3,297.9 607.0,298.7 606.4,299.6 606.0,300.6 605.7,301.4 605.2,302.7 604.0,303.3 601.4,303.4 598.3,303.5 596.5,305.0 596.7,306.4 596.9,307.2 597.1,307.8 598.8,309.1 600.0,310.4 600.7,311.5 601.5,312.2 602.3,313.4 602.2,314.3 602.1,315.2 601.9,315.8 601.8,316.1 601.8,317.1 601.3,317.7 600.8,318.8 599.4,320.0 599.6,321.5 599.7,322.2 599.1,323.4 597.6,325.2 597.1,326.4 596.6,327.2 595.6,328.0 594.8,328.9 593.5,329.7 592.7,330.4 591.9,332.0 590.4,332.1 588.9,331.5 588.4,331.9 583.8,333.3 575.5,334.2 566.7,334.6 566.7,330.3 567.1,326.7 566.9,326.6 567.8,319.1 568.2,315.3 570.5,311.5 571.5,308.1 571.9,305.4 571.9,304.1 571.8,301.3 571.6,299.5 570.3,296.8 568.0,293.5 564.8,292.3 563.4,293.3 561.9,295.5 561.3,295.0 560.4,294.1 560.0,293.2 559.8,292.3 559.5,291.8 558.8,291.6 557.9,291.7 555.9,290.6 554.9,288.7 554.8,287.2 554.0,286.0 553.4,285.7 553.0,285.5 552.4,285.2 552.6,283.6 552.6,281.6 552.5,281.2 552.5,280.9 552.5,280.6 554.6,279.5 555.5,278.3 555.8,277.8 555.7,277.5 555.3,276.9 554.6,276.8 553.7,277.2 552.4,278.3 551.0,280.0 549.7,281.1 546.7,282.1 546.0,282.2 545.2,282.2 544.3,282.0 542.6,281.9 541.6,280.7 541.9,279.6 541.2,278.8 541.0,278.4 541.0,278.0 540.6,277.1 540.3,276.9 539.9,277.1 539.5,277.1 539.3,276.9 538.4,277.9 537.4,278.6 535.6,278.1 534.3,278.4 533.3,277.9 532.9,277.1 531.7,277.7 530.6,277.2 530.3,276.4 529.0,276.3 528.8,277.4 527.8,277.6 528.3,279.8 530.0,282.0 531.0,282.7 531.9,285.1 531.8,286.9 530.8,287.4 529.9,289.0 529.5,289.4 528.8,289.7 527.1,289.7 525.4,289.7 524.1,290.3 523.2,290.8 522.3,292.0 521.4,292.7 520.5,292.8 520.0,292.6 518.5,292.8 517.8,293.5 517.1,294.2 515.1,297.2 514.4,298.5 513.0,298.6 511.6,299.2 510.1,300.2 508.5,300.4 507.3,301.0 506.9,302.0 506.3,303.0 503.6,304.9 502.0,305.1 500.7,305.1 498.4,304.1 497.6,302.7 496.5,301.8 495.5,301.6 494.4,301.7 493.8,302.3 492.8,302.6 491.9,302.1 486.7,301.1 485.1,299.8 482.1,301.3 479.6,303.1 478.5,304.8 477.6,306.1 474.4,306.2 473.1,305.1 471.7,303.1 469.3,301.6 467.1,298.9 465.9,297.8 463.3,296.0 462.2,294.1 461.8,293.3 460.2,292.2 458.8,291.4 456.2,289.1 456.0,287.0 456.0,285.8 456.4,285.3 456.9,285.9 457.5,285.9 457.5,285.2 458.0,285.1 458.6,285.6 458.7,285.6 458.9,285.5 459.3,284.8 459.4,284.8 459.5,284.8 460.1,285.1 460.2,285.1 460.3,285.1 460.4,285.0 460.5,284.6 460.8,284.1 461.8,283.2 462.0,283.2 462.4,282.7 462.6,282.7 462.8,282.7 463.0,282.6 463.2,282.3 463.4,281.6 463.2,280.9 463.2,280.8 463.3,280.7 463.6,280.5 463.9,280.5 464.0,280.6 464.3,280.4 464.6,280.5 464.7,280.4 464.9,280.4 465.4,280.3 466.0,278.9 466.6,278.9 467.1,278.9 468.7,277.9 469.9,276.9 470.9,275.2 470.9,274.0 469.9,271.6 469.0,270.7 468.9,269.8 468.4,269.8 468.1,269.3 467.6,269.4 467.1,269.0 466.8,268.5 467.3,267.4 467.7,267.3 468.2,266.7 467.0,265.0 466.6,264.8 466.9,263.8 467.2,262.8 468.2,261.8 468.3,259.8 468.6,259.0 468.2,257.9 468.3,257.6 468.1,257.3 467.9,257.1 467.7,256.6 468.1,256.1 468.2,255.5 468.5,255.2 468.5,254.9 468.1,254.3 466.6,253.9 466.3,253.4 466.1,252.9 466.1,252.6 466.8,251.7 466.6,251.2 465.9,250.4 465.8,250.1 465.5,249.2 464.6,248.5 464.0,247.7 463.5,247.0 463.8,246.0 465.3,243.8 465.2,242.3 463.7,240.1 462.9,239.3 462.0,238.7 459.8,238.7 459.3,237.8 458.5,237.4 456.7,236.5 453.8,236.4 451.9,235.1 451.1,233.5 451.0,232.5 451.2,231.0 452.3,229.6 453.1,227.2 454.4,226.0 455.9,225.0 457.1,224.7 460.7,224.7 460.9,223.5 460.7,223.2 460.4,223.0 460.1,223.0 459.9,222.9 459.9,222.8 460.6,221.8 460.7,221.7 460.7,221.6 460.9,221.3 461.0,221.0 461.3,220.8 461.4,220.6 461.4,220.5 461.0,220.4 460.9,220.3 460.8,220.3 460.7,220.2 460.6,220.2 460.6,220.4 460.5,220.5 460.2,220.5 460.2,220.3 460.1,220.2 460.1,220.4 460.0,220.6 460.0,220.6 459.9,220.4 460.0,220.3 460.1,220.2 460.0,220.1 459.8,220.1 459.6,220.3 459.7,220.5 459.6,220.6 459.5,220.6 459.4,220.5 459.4,220.4 459.3,220.3 459.2,220.3 459.1,220.4 459.1,220.7 459.1,220.8 459.0,220.8 458.9,220.8 458.8,220.6 458.6,220.7 458.6,220.7 458.8,220.9 458.8,221.0 458.8,221.1 458.5,221.1 458.5,221.1 458.6,221.0 458.5,220.8 458.4,220.8 458.4,220.9 458.3,221.1 458.0,221.1 458.0,221.1 457.8,221.0 457.7,221.1 457.7,221.1 457.6,220.9 457.4,220.8 457.3,220.6 457.3,220.5 457.5,220.4 457.3,220.3 457.4,220.3 457.5,220.2 457.5,220.0 457.6,220.0 457.7,220.1 457.8,220.1 457.8,219.9 457.8,219.9 458.2,219.9 458.1,219.7 458.2,219.5 458.4,219.6 458.3,219.4 458.4,219.3 458.5,219.4 458.5,219.5 458.7,219.4 458.7,219.2 459.0,219.1 459.0,219.2 459.3,219.1 459.3,218.9 459.4,218.8 459.3,218.8 459.2,219.0 459.1,218.9 459.0,218.9 459.0,218.7 459.0,218.6 458.7,218.5 458.6,218.6 458.5,218.7 458.5,218.6 458.5,218.4 458.3,218.4 458.2,218.3 458.2,218.2 458.4,218.0 458.1,217.7 457.4,217.9 455.8,218.5 454.4,218.4 453.5,218.1 453.0,217.5 452.7,217.0 452.3,216.7 451.6,216.1 451.5,215.0 451.4,215.0 450.6,213.9 449.6,213.1 449.3,212.4 449.6,211.2 449.6,210.2 449.5,209.8 449.3,209.6 449.1,209.2 449.0,209.2 449.0,209.7 448.3,209.9 447.9,209.8 447.7,209.6 447.0,209.3 446.5,208.8 446.2,207.5 446.2,207.3 446.6,206.6 447.0,206.4 447.2,205.7 447.6,205.3 447.6,204.9 447.5,204.5 446.7,204.5 446.3,204.8 445.6,205.3 445.0,205.7 444.5,205.9 444.0,205.9 443.5,205.7 443.4,205.4 443.5,205.1 444.0,204.1 444.1,203.7 444.3,202.5 444.7,202.0 444.3,201.5 443.6,201.9 443.4,202.2 443.3,202.6 442.1,203.7 440.8,204.3 440.1,204.4 439.8,204.5 438.9,204.5 438.3,204.2 437.4,203.7 437.0,203.6 435.9,203.1 435.0,203.0 434.3,203.0 434.0,203.1 433.6,203.3 433.1,203.9 432.6,204.6 432.1,204.6 431.5,204.3 430.9,203.8 430.5,203.2 429.8,202.8 429.6,202.3 429.0,202.2 428.7,202.7 428.7,203.6 427.8,203.9 427.2,204.4 426.1,204.6 425.8,204.3 425.2,204.3 424.5,204.9 424.1,203.8 423.5,203.5 423.5,203.2 423.7,203.0 424.9,202.6 425.4,202.7 426.2,202.5 426.4,202.3 426.7,202.1 426.7,201.9 426.7,201.8 426.5,201.6 426.3,201.5 426.0,201.6 425.7,201.5 425.5,201.4 425.2,201.4 425.0,201.0 424.8,200.9 424.6,200.9 424.1,200.7 423.8,200.4 423.6,200.5 423.0,200.5 421.7,201.2 420.5,201.6 420.0,202.1 419.4,201.8 418.7,201.1 417.1,200.6 416.8,200.5 415.7,200.8 415.0,200.5 414.1,200.5 413.0,200.7 412.4,200.6 411.9,200.7 411.2,200.9 410.3,201.2 409.7,201.9 408.6,202.1 406.6,201.4 405.9,200.2 404.9,200.2 404.0,200.1 403.6,199.7 403.2,199.6 402.8,200.9 402.1,201.5 401.8,201.1 401.4,200.9 400.4,201.8 399.1,201.4 397.1,201.9 396.1,202.8 395.9,203.4 396.0,203.7 396.0,203.8 395.9,203.9 395.6,203.9 395.2,204.1 395.0,204.1 395.0,203.7 394.9,203.6 394.7,203.5 394.5,203.5 393.8,203.6 393.4,203.3 393.2,203.5 392.4,203.5 391.8,203.3 391.3,203.2 391.0,203.5 390.5,203.5 390.2,203.7 389.5,203.0 388.6,203.0 384.0,200.3 383.3,198.7 383.2,197.6 383.5,196.4 383.3,195.6 382.8,194.6 382.6,194.3 382.3,193.6Z"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

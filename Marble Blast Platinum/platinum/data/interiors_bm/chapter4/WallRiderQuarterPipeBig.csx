<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/09/24 22:08:58">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="16">
                    <Brush id="0" owner="0" type="0" pos="0 2.7367 2.47918" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 2.7367 0 0 1 2.47918 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2 -0.0132797 -0.26812" />
                            <Vertex pos="2 0.0132799 0.27073" />
                            <Vertex pos="-2 -0.0132797 -0.26812" />
                            <Vertex pos="-2 0.0132799 0.27073" />
                            <Vertex pos="2 0.0132799 -0.27073" />
                            <Vertex pos="-2 0.0132799 -0.27073" />
                        </Vertices>
                        <Face id="0" plane="0 -0.998787 0.0492296 -6.41132e-005" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.19509 -0.980786 64.0301 0 0.125 0.134125" texRot="0" texScale="0.125 0.134125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 446.297 0 0 -1 34.682 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1 0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -446.297 0 0 -1 34.682 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2" />
                        </Face>
                        <Face id="3" plane="0 -0.0977708 -0.995209 -0.268134" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 1 0 175.575 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 1 -0 -0.0132799" album="" material="bm_grid_blank1" texgens="0 0 1 19.5572 1 0 0 55.6599 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="-4.70877e-006 2.6972 1.93358" rot="1 0 0 0" scale="" transform="1 0 0 -4.70877e-006 0 1 0 2.6972 0 0 1 1.93358 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.0262504 0.277477" />
                            <Vertex pos="1.99999 -0.0528123 -0.256455" />
                            <Vertex pos="-2 0.0262504 0.277477" />
                            <Vertex pos="-2 -0.0528123 -0.256455" />
                            <Vertex pos="2 0.0528123 0.274871" />
                            <Vertex pos="1.99999 0.052809 -0.277477" />
                            <Vertex pos="-2 0.0528123 0.274871" />
                            <Vertex pos="-2 0.052809 -0.277477" />
                        </Vertices>
                        <Face id="0" plane="0 -0.989214 0.146479 -0.0146774" album="" material="bm_tile04_C" texgens="1 0 0 -0.00120544 0 -0.19509 -0.980786 193.535 0 0.125 0.134125" texRot="0" texScale="0.125 0.134125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -3.36685e-006 -1.69163e-005 -1.99999" album="" material="bm_grid_blank1" texgens="0 1 0 441.242 0 0 -1 104.519 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -441.242 0 0 -1 104.519 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.0976471 0.995221 -0.278714" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9996 0 0.995185 -0.0980136 176.03 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.195202 -0.980763 -0.261831" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9996 0 0.995185 -0.0980136 176.03 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -6.04304e-006 -0.0528107" album="" material="bm_grid_blank1" texgens="0 0 1 24.6249 1 0 0 55.1403 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="0 2.6316 1.37943" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 2.6316 0 0 1 1.37943 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.0128078 0.297688" />
                            <Vertex pos="2 -0.118438 -0.225847" />
                            <Vertex pos="-1.99999 0.0128078 0.297688" />
                            <Vertex pos="-1.99998 -0.118439 -0.22585" />
                            <Vertex pos="2 0.118439 0.276669" />
                            <Vertex pos="2 0.118436 -0.297685" />
                            <Vertex pos="-2 0.118439 0.276669" />
                            <Vertex pos="-2 0.118436 -0.297688" />
                        </Vertices>
                        <Face id="0" plane="0 -0.969984 0.243168 -0.0599647" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.19509 -0.980786 326.283 0 0.125 0.134125" texRot="0" texScale="0.125 0.134125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 432.844 0 0 -1 175.449 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -8.91546e-005 4.81112e-010 -1.99999" album="" material="bm_grid_blank1" texgens="0 -1 0 -432.844 0 0 -1 175.449 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.195157 0.980772 -0.294463" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.980785 -0.195092 177.458 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="7.07851e-007 -0.290219 -0.95696 -0.250501" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.980785 -0.195092 177.458 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="4.18146e-012 1 -5.3964e-006 -0.118438" album="" material="bm_grid_blank1" texgens="0 0 1 28.9593 1 0 0 54.6399 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="0 2.5406 0.81276" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 2.5406 0 0 1 0.81276 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.00001 -0.0274994 0.340822" />
                            <Vertex pos="2.00001 -0.209378 -0.1674" />
                            <Vertex pos="-2.00001 -0.0274994 0.340819" />
                            <Vertex pos="-2.00001 -0.209378 -0.1674" />
                            <Vertex pos="2.00001 0.209378 0.268984" />
                            <Vertex pos="2.00001 0.209378 -0.340822" />
                            <Vertex pos="-2.00001 0.209378 0.268981" />
                            <Vertex pos="-2.00001 0.209378 -0.340822" />
                        </Vertices>
                        <Face id="0" plane="-2.51043e-007 -0.941524 0.336946 -0.14073" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.19509 -0.980786 463.104 0 0.125 0.134125" texRot="0" texScale="0.125 0.134125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2.00001" album="" material="bm_grid_blank1" texgens="0 1 0 421.203 0 0 -1 247.983 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2.00001" album="" material="bm_grid_blank1" texgens="0 -1 0 -421.203 0 0 -1 247.983 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-7.41508e-007 0.290215 0.956961 -0.318171" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9998 0 0.956941 -0.290281 180.003 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="5.14658e-009 -0.382622 -0.923905 -0.234774" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9998 0 0.956941 -0.290281 180.003 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.209378" album="" material="bm_grid_blank1" texgens="0 0 1 32.2334 1 0 0 54.1902 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="0 2.4253 0.227847" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 2.4253 0 0 1 0.227847 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.0940623 0.417512" />
                            <Vertex pos="2 -0.324691 -0.0703907" />
                            <Vertex pos="-2 -0.0940623 0.417512" />
                            <Vertex pos="-2 -0.324691 -0.0703907" />
                            <Vertex pos="2 0.324691 0.244097" />
                            <Vertex pos="2 0.324684 -0.417512" />
                            <Vertex pos="-2 0.324691 0.244097" />
                            <Vertex pos="-2 0.324684 -0.417512" />
                        </Vertices>
                        <Face id="0" plane="0 -0.904084 0.427354 -0.263466" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.555568 -0.831472 70.3801 0 0.125 0.134125" texRot="0" texScale="0.125 0.134125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 406.438 0 0 -1 322.851 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -406.438 0 0 -1 322.851 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.382613 0.923909 -0.349754" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.923879 -0.382686 183.892 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.471421 -0.881908 -0.215144" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.923879 -0.382686 183.892 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -9.36941e-006 -0.324688" album="" material="bm_grid_blank1" texgens="0 0 1 34.0584 1 0 0 53.8101 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="0 2.2866 -0.383702" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 2.2866 0 0 1 -0.383702 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.00001 -0.185937 0.541169" />
                            <Vertex pos="2.00001 -0.463438 0.0781813" />
                            <Vertex pos="-2.00001 -0.185936 0.541169" />
                            <Vertex pos="-2.00001 -0.463437 0.0781801" />
                            <Vertex pos="2.00001 0.463438 0.194046" />
                            <Vertex pos="2.00001 0.463438 -0.541168" />
                            <Vertex pos="-2.00001 0.463438 0.194046" />
                            <Vertex pos="-2.00001 0.463438 -0.541169" />
                        </Vertices>
                        <Face id="0" plane="-2.58123e-007 -0.857732 0.514097 -0.437698" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.555568 -0.831472 210.05 0 0.125 0.134125" texRot="0" texScale="0.125 0.134125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2.00001" album="" material="bm_grid_blank1" texgens="0 1 0 388.68 0 0 -1 401.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2.00001" album="" material="bm_grid_blank1" texgens="0 -1 0 -388.68 0 0 -1 401.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.471424 0.881907 -0.389606" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9998 0 0.881923 -0.471395 189.413 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="2.10509e-007 -0.55559 -0.831457 -0.192477" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9998 0 0.881923 -0.471395 189.413 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.463438" album="" material="bm_grid_blank1" texgens="0 0 1 33.9854 1 0 0 53.5103 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="0 2.1258 -1.03455" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 2.1258 0 0 1 -1.03455 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.302658 0.729027" />
                            <Vertex pos="2 -0.624214 0.295523" />
                            <Vertex pos="-2 -0.302658 0.729027" />
                            <Vertex pos="-2 -0.624214 0.295523" />
                            <Vertex pos="2 0.624214 0.109683" />
                            <Vertex pos="2 0.624214 -0.729026" />
                            <Vertex pos="-2 0.624214 0.109683" />
                            <Vertex pos="-2 0.624214 -0.729026" />
                        </Vertices>
                        <Face id="0" plane="0 -0.803165 0.595757 -0.677407" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.555568 -0.831472 360.496 0 0.125 0.134125" texRot="0" texScale="0.125 0.134125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 368.102 0 0 -1 484.438 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -368.102 0 0 -1 484.438 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.555587 0.831458 -0.438002" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.831468 -0.555572 197.014 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.63439 -0.773013 -0.167552" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.831468 -0.555572 197.014 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -2.84268e-007 -0.624214" album="" material="bm_grid_blank1" texgens="0 0 1 31.4278 1 0 0 53.3 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="5.96046e-008 1.9445 -1.74446" rot="1 0 0 0" scale="" transform="1 0 0 5.96046e-008 0 1 0 1.9445 0 0 1 -1.74446 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.442967 1.00544" />
                            <Vertex pos="2 -0.805467 0.605486" />
                            <Vertex pos="-2 -0.442967 1.00544" />
                            <Vertex pos="-2 -0.805467 0.605486" />
                            <Vertex pos="2 0.805467 -0.0191139" />
                            <Vertex pos="2 0.805467 -1.00544" />
                            <Vertex pos="-2 0.805467 -0.0191139" />
                            <Vertex pos="-2 0.805467 -1.00544" />
                        </Vertices>
                        <Face id="0" plane="0 -0.740948 0.671563 -1.00343" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.555568 -0.831472 525.351 0 0.125 0.134125" texRot="0" texScale="0.125 0.134125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 344.898 0 0 -1 575.308 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -344.898 0 0 -1 575.308 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.634389 0.773014 -0.496204" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.773012 -0.634391 207.368 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.707105 -0.707109 -0.141405" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.773012 -0.634391 207.368 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.805467" album="" material="bm_grid_blank1" texgens="0 0 1 25.597 1 0 0 53.2 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="0 0.3839 -2.28641" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0.3839 0 0 1 -2.28641 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.0782739 0.463458" />
                            <Vertex pos="2 -0.5411 0.185983" />
                            <Vertex pos="-2 -0.0782739 0.463458" />
                            <Vertex pos="-2 -0.5411 0.185983" />
                            <Vertex pos="2 0.5411 -0.463458" />
                            <Vertex pos="2 -0.194225 -0.463458" />
                            <Vertex pos="-2 0.5411 -0.463458" />
                            <Vertex pos="-2 -0.194225 -0.463458" />
                        </Vertices>
                        <Face id="0" plane="0 -0.514195 0.857673 -0.437743" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.83147 -0.55557 301.885 0 0.125 0.134125" texRot="0" texScale="0.125 0.134125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 145.141 0 0 -1 644.677 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -145.141 0 0 -1 644.677 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.831458 0.555588 -0.19241" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.555568 -0.831471 189.723 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.882067 -0.471124 -0.389666" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.555568 -0.831471 189.723 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.463458" album="" material="bm_grid_blank1" texgens="0 -1 0 31.3951 1 0 0 53.51 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="0 -0.227799 -2.42515" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -0.227799 0 0 1 -2.42515 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.00001 0.0706293 0.324723" />
                            <Vertex pos="2.00001 -0.417507 0.0939269" />
                            <Vertex pos="-2.00001 0.0706293 0.324723" />
                            <Vertex pos="-2.00001 -0.417507 0.0939269" />
                            <Vertex pos="2.00001 0.417507 -0.324723" />
                            <Vertex pos="2.00001 -0.244063 -0.32472" />
                            <Vertex pos="-2.00001 0.417507 -0.324723" />
                            <Vertex pos="-2.00001 -0.244063 -0.32472" />
                        </Vertices>
                        <Face id="0" plane="0 -0.427442 0.904043 -0.263374" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.83147 -0.55557 441.645 0 0.125 0.134125" texRot="0" texScale="0.125 0.134125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2.00001" album="" material="bm_grid_blank1" texgens="0 1 0 66.8438 0 0 -1 662.436 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2.00001" album="" material="bm_grid_blank1" texgens="0 -1 0 -66.8438 0 0 -1 662.436 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.882067 0.471123 -0.215285" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9998 0 0.471398 -0.881921 184.101 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.923853 -0.382748 -0.349765" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9998 0 0.471398 -0.881921 184.101 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0 -4.68497e-006 -1 -0.324722" album="" material="bm_grid_blank1" texgens="0 -1 0 30.58 1 0 0 53.8103 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="0 -0.812698 -2.54054" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -0.812698 0 0 1 -2.54054 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.167342 0.209328" />
                            <Vertex pos="2 -0.340783 0.0275059" />
                            <Vertex pos="-2 0.167342 0.209328" />
                            <Vertex pos="-2 -0.340783 0.0275059" />
                            <Vertex pos="2 0.340783 -0.209328" />
                            <Vertex pos="2 -0.268905 -0.209328" />
                            <Vertex pos="-2 0.340783 -0.209328" />
                            <Vertex pos="-2 -0.268905 -0.209328" />
                        </Vertices>
                        <Face id="0" plane="0 -0.336909 0.941537 -0.140711" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.980786 -0.195087 48.8658 0 0.125 0.134123" texRot="0" texScale="0.125 0.134123" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 -8.01559 0 0 -1 677.206 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 8.01559 0 0 -1 677.206 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.923858 0.382735 -0.234718" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.38268 -0.923881 180.139 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.956901 -0.290415 -0.318107" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.38268 -0.923881 180.139 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.209328" album="" material="bm_grid_blank1" texgens="0 -1 0 27.9849 1 0 0 54.1899 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="0 -1.3794 -2.63145" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -1.3794 0 0 1 -2.63145 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.225938 0.118416" />
                            <Vertex pos="2 -0.297816 -0.0127375" />
                            <Vertex pos="-2 0.225938 0.118416" />
                            <Vertex pos="-2 -0.297816 -0.0127375" />
                            <Vertex pos="2 0.297816 -0.118416" />
                            <Vertex pos="2 -0.276569 -0.118416" />
                            <Vertex pos="-2 0.297816 -0.118416" />
                            <Vertex pos="-2 -0.276569 -0.118416" />
                        </Vertices>
                        <Face id="0" plane="0 -0.24291 0.970049 -0.0599864" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.980786 -0.195087 185.771 0 0.125 0.134123" texRot="0" texScale="0.125 0.134123" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 -80.5627 0 0 -1 688.843 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 80.5627 0 0 -1 688.843 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.9569 0.290418 -0.25059" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.290286 -0.95694 177.528 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.980382 -0.197108 -0.294484" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.290286 -0.95694 177.528 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.118416" album="" material="bm_grid_blank1" texgens="0 -1 0 24.12 1 0 0 54.6399 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="0 -1.9334 -2.69703" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -1.9334 0 0 1 -2.69703 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.256252 0.0528409" />
                            <Vertex pos="2 -0.277499 -0.0263591" />
                            <Vertex pos="-2 0.256252 0.0528409" />
                            <Vertex pos="-2 -0.277499 -0.0263591" />
                            <Vertex pos="2 0.277499 -0.0528409" />
                            <Vertex pos="2 -0.274999 -0.0528409" />
                            <Vertex pos="-2 0.277499 -0.0528409" />
                            <Vertex pos="-2 -0.274999 -0.0528409" />
                        </Vertices>
                        <Face id="0" plane="0 -0.146777 0.98917 -0.0146568" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.980786 -0.195087 318.438 0 0.125 0.134123" texRot="0" texScale="0.125 0.134123" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 -151.477 0 0 -1 697.236 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 151.477 0 0 -1 697.236 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.980383 0.197103 -0.26164" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.195085 -0.980786 176.057 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.995573 -0.0939885 -0.278748" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.195085 -0.980786 176.057 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.0528409" album="" material="bm_grid_blank1" texgens="0 -1 0 19.37 1 0 0 55.1399 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="0 -2.4793 -2.73663" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -2.4793 0 0 1 -2.73663 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2 0.268329 0.0132406" />
                            <Vertex pos="2 -0.270825 -0.0132406" />
                            <Vertex pos="-2 0.268329 0.0132375" />
                            <Vertex pos="-2 -0.270762 -0.0132406" />
                            <Vertex pos="2 0.270825 -0.0132406" />
                            <Vertex pos="-2 0.270825 -0.0132406" />
                        </Vertices>
                        <Face id="0" plane="-7.76851e-007 -0.049057 0.998796 -5.96859e-005" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.980786 -0.195087 448.001 0 0.125 0.134123" texRot="0" texScale="0.125 0.134123" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 -221.344 0 0 -1 702.305 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0" />
                        </Face>
                        <Face id="2" plane="-1 0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 221.344 0 0 -1 702.305 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.995586 0.0938577 -0.268387" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.0980177 -0.995185 175.58 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.0132406" album="" material="bm_grid_blank1" texgens="0 -1 0 14.1064 1 0 0 55.6599 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="0 1.7445 -1.94444" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 1.7445 0 0 1 -1.94444 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.99999 -0.605467 0.805466" />
                            <Vertex pos="-1.99999 -0.605467 0.805466" />
                            <Vertex pos="1.99999 -1.00547 0.443019" />
                            <Vertex pos="-1.99999 -1.00547 0.443019" />
                            <Vertex pos="1.99999 1.00547 -0.805466" />
                            <Vertex pos="-1.99999 1.00547 -0.805466" />
                            <Vertex pos="1.99999 0.0192235 -0.805434" />
                            <Vertex pos="-1.99999 0.0192235 -0.805434" />
                        </Vertices>
                        <Face id="0" plane="0 -0.671463 0.741039 -1.00343" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.83147 -0.55557 -13.3651 0 0.125 0.134125" texRot="0" texScale="0.125 0.134125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 0.707105 0.707108 -0.141422" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9998 0 0.707105 -0.707109 207.927 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="1 -0 0 -1.99999" album="" material="bm_grid_blank1" texgens="0 1 0 319.297 0 0 -1 600.904 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-1 0 0 -1.99999" album="" material="bm_grid_blank1" texgens="0 -1 0 -319.297 0 0 -1 600.904 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 -0.772976 -0.634436 -0.496137" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9998 0 0.707105 -0.707109 207.927 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="-0 -3.16684e-005 -1 -0.805434" album="" material="bm_grid_blank1" texgens="0 -1 0 25.0551 1 0 0 53.2002 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="0 1.0347 -2.12564" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 1.0347 0 0 1 -2.12564 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.729063 0.302681" />
                            <Vertex pos="-2 -0.729063 0.302681" />
                            <Vertex pos="2 -0.295624 0.624228" />
                            <Vertex pos="-2 -0.295624 0.624228" />
                            <Vertex pos="2 -0.109693 -0.624228" />
                            <Vertex pos="-2 -0.109693 -0.624228" />
                            <Vertex pos="2 0.729063 -0.624228" />
                            <Vertex pos="-2 0.729063 -0.624228" />
                        </Vertices>
                        <Face id="0" plane="0 -0.595803 0.80313 -0.67747" album="" material="bm_tile04_C" texgens="1 0 0 0 0 -0.83147 -0.55557 151.519 0 0.125 0.134125" texRot="0" texScale="0.125 0.134125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.831458 -0.555588 -0.438019" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.634395 -0.773009 197.44 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="1 0 -0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 228.438 0 0 -1 624.099 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="-1 0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -228.438 0 0 -1 624.099 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 0.772978 0.634432 -0.167519" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.634395 -0.773009 197.44 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.624228" album="" material="bm_grid_blank1" texgens="0 -1 0 83.1297 1 0 0 234.11 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
